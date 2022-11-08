using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColors : MonoBehaviour
{   
    public Color HighlightColor = new Color(1.0f, 0.0f, 0.0f);
    public Color BaseColor = new Color(0.0f, 0.0f, 1.0f);
    // Start is called before the first frame update
    public Color rainbow1 = Color.red;
    public Color rainbow2 = Color.yellow;
    public Color rainbow3 = Color.green;
    public Color rainbow4 = Color.cyan;
    public Color rainbow5 = Color.blue;
    public Color rainbow6 = Color.magenta;
    public Color newcolor = new Color(0.0f, 0.0f, 1.0f);
    public float duration = 1.0f;
    public float timer = 0f;
    Color RandomColor;
    public float FresnelPower = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.T))//2.
        {
            GetComponent<Renderer>().material.SetColor("_BaseColor",HighlightColor);
        }
        else
        {
            GetComponent<Renderer>().material.SetColor("_BaseColor",newcolor);
        }



        if (Input.GetKey(KeyCode.R))//3.
        {
            timer += Time.deltaTime;
            if ((timer % 6)<1) { 
            GetComponent<Renderer>().material.SetColor("_BaseColor", rainbow1);
            }else if (timer % 6 < 2)
            {
            GetComponent<Renderer>().material.SetColor("_BaseColor", rainbow2);
            }
            else if (timer % 6 < 3)
            {
                GetComponent<Renderer>().material.SetColor("_BaseColor", rainbow3);
            }
            else if (timer % 6 < 4)
            {
                GetComponent<Renderer>().material.SetColor("_BaseColor", rainbow4);
            }
            else if (timer % 6 < 5)
            {
                GetComponent<Renderer>().material.SetColor("_BaseColor", rainbow5);
            }
            else 
            {
                GetComponent<Renderer>().material.SetColor("_BaseColor", rainbow6);
            }
            newcolor = GetComponent<Renderer>().material.GetColor("_BaseColor");

        }
        else if(Input.GetKeyUp(KeyCode.R))
        {
            GetComponent<Renderer>().material.SetColor("_BaseColor", newcolor);
        }



        if (Input.GetKey(KeyCode.Q))//4.
        {
            newcolor = BaseColor;
        }



        if (Input.GetKeyDown(KeyCode.X))//5
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            newcolor = new Color(r, g, b);
        }



        if (Input.GetKeyDown(KeyCode.P))
        {
            if (FresnelPower < 1 ) { 
            FresnelPower += 0.05f;
            }
            if (FresnelPower > 1)
            {
                FresnelPower = 1f;
            }
            GetComponent<Renderer>().material.SetFloat("_FresnelPower", FresnelPower);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (FresnelPower > 0)
            {
                FresnelPower -= 0.05f;
            }
            if (FresnelPower <0)
            {
                FresnelPower = 0f;
            }
            GetComponent<Renderer>().material.SetFloat("_FresnelPower", FresnelPower);
        }
    }
}

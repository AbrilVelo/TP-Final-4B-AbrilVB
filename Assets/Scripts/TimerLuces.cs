using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerLuces : MonoBehaviour {

    // ESTE SCRIPT ES PARA EL TIMER Y EL CAMBIO DE COLOR DE LAS BALDOSAS
    private Renderer c1;
    private Renderer c2;
    private Renderer c3;
    private Renderer c4;
    private Renderer c5;
    private Renderer c6;
    private Renderer c7;
    private Renderer c8;
    private Renderer c9;
    private Renderer c10;
    int counter;
    public GameObject Correcto1;
    public GameObject Correcto2;
    public GameObject Correcto3;
    public GameObject Correcto4;
    public GameObject Correcto5;
    public GameObject Correcto6;
    public GameObject Correcto7;
    public GameObject Correcto8;
    public GameObject Correcto9;
    public GameObject Correcto10;
    public Text txtCountdown;
    private Color prendido;
    private Color apagado;



    void Start () {

        c1 = Correcto1.GetComponent<Renderer>(); c2 = Correcto2.GetComponent<Renderer>(); c3 = Correcto3.GetComponent<Renderer>();
        c4 = Correcto4.GetComponent<Renderer>(); c5 = Correcto5.GetComponent<Renderer>(); c6 = Correcto6.GetComponent<Renderer>();
        c7 = Correcto7.GetComponent<Renderer>(); c8 = Correcto8.GetComponent<Renderer>(); c9 = Correcto9.GetComponent<Renderer>();
        c10 = Correcto10.GetComponent<Renderer>();

        c1.material.SetColor("_Color", prendido);


    }
	
	void Update () {
        txtCountdown.text = Mathf.FloorToInt(Time.time).ToString();

       

       
         if(txtCountdown.text == "1")
        {
            c1.material.SetColor("_Color", prendido);
            
            }
            if (txtCountdown.text == "2")
            {
            c2.material.SetColor("_Color", prendido);
        }
            if (txtCountdown.text == "3")
            {
            c3.material.SetColor("_Color", prendido);
        }
            if (txtCountdown.text == "4")
            {
            c4.material.SetColor("_Color", prendido);
        }
            if (txtCountdown.text == "5")
            {
            c5.material.SetColor("_Color", prendido);
        }
            if (txtCountdown.text == "6")
            {
            c6.material.SetColor("_Color", prendido);
        }
            if (txtCountdown.text == "7")
            {
            c7.material.SetColor("_Color", prendido);
        }
            if (txtCountdown.text == "8")
            {
            c8.material.SetColor("_Color", prendido);
        }
            if (txtCountdown.text == "9")
            {
            c9.material.SetColor("_Color", prendido);
        }
            if (txtCountdown.text == "10")
            {
            c10.material.SetColor("_Color", prendido);
             
        }
            if(txtCountdown.text == "11")
        {
            txtCountdown.text = "0";
        }

    }
            
               
}

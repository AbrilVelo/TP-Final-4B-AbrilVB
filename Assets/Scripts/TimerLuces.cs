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
    //
    public GameObject CorrectoA;
    public GameObject CorrectoB;
    public GameObject CorrectoC;
    public GameObject CorrectoD;
    public GameObject CorrectoE;
    public GameObject CorrectoF;
    public GameObject CorrectoG;
    public GameObject CorrectoH;
    public GameObject CorrectoI;
    public GameObject CorrectoJ;

    public Text txtCountdown;
    public Text PerdisteTxt;
    private Color prendido;
    private Color apagado;



    void Start () {

        c1 = Correcto1.GetComponent<Renderer>(); c2 = Correcto2.GetComponent<Renderer>(); c3 = Correcto3.GetComponent<Renderer>();
        c4 = Correcto4.GetComponent<Renderer>(); c5 = Correcto5.GetComponent<Renderer>(); c6 = Correcto6.GetComponent<Renderer>();
        c7 = Correcto7.GetComponent<Renderer>(); c8 = Correcto8.GetComponent<Renderer>(); c9 = Correcto9.GetComponent<Renderer>();
        c10 = Correcto10.GetComponent<Renderer>();

        // c1.material.SetColor("_Color", prendido);
        apagado = Color.black;
        prendido = Color.white;

    }
	
	void Update () {
        txtCountdown.text = Mathf.FloorToInt(Time.time).ToString();
        //txtCountdown.text = Time.time.ToString();

        string tm = txtCountdown.text;

        if (tm == "1" || tm == "21")
        {
            c10.material.SetColor("_Color", apagado);
            c1.material.SetColor("_Color", prendido);
            
            }
            if (tm == "2" || tm == "22")
            {
            c1.material.SetColor("_Color", apagado);
            c2.material.SetColor("_Color", prendido);
        }
            if (tm == "3" || tm == "23")
            {
            c2.material.SetColor("_Color", apagado);
            c3.material.SetColor("_Color", prendido);
        }
            if (tm == "4" || tm== "24")
            {
            c3.material.SetColor("_Color", apagado);
            c4.material.SetColor("_Color", prendido);
        }
            if (tm == "5" || tm == "25")
            {
            c4.material.SetColor("_Color", apagado);
            c5.material.SetColor("_Color", prendido);
        }
            if (tm == "6" || tm == "26")
            {
            c5.material.SetColor("_Color", apagado);
            c6.material.SetColor("_Color", prendido);
        }
            if (tm == "7" || tm == "27")
            {
            c6.material.SetColor("_Color", apagado);
            c7.material.SetColor("_Color", prendido);
        }
            if (tm == "8" || tm == "28")
            {
            c7.material.SetColor("_Color", apagado);
            c8.material.SetColor("_Color", prendido);
        }
            if (tm == "9" || tm == "29")
            {
            c8.material.SetColor("_Color", apagado);
            c9.material.SetColor("_Color", prendido);
        }
            if (tm == "10" || tm == "30")
            {
            c9.material.SetColor("_Color", apagado);
            c10.material.SetColor("_Color", prendido);
             
        }
        if (tm == "11" || tm == "31")
        {
           
            c10.material.SetColor("_Color", apagado);
        }
        if(tm == "40")
        {
            PerdisteTxt.text = "Perdiste";
        }

        }


    }

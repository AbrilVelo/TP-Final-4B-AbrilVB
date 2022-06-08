using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerLuces : MonoBehaviour {
 
    // ESTE SCRIPT ES PARA EL TIMER Y EL CAMBIO DE COLOR DE LAS BALDOSAS
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
    private Material prendido;
    //public Color Prendido;

   
    void Start () {

       // mr = gameObject.GetComponent<Renderer>();
    }
	
	void Update () {
        txtCountdown.text = Mathf.FloorToInt(Time.time).ToString();

       
            if (txtCountdown.text == "1")
            {
            prendido.color = Color.black;
            //Correcto1.Material.Color
            //Correcto1. //cambiar color
            Debug.Log("Si");
            }
            if (txtCountdown.text == "2")
            {
                //Correcto2
            }
            if (txtCountdown.text == "3")
            {
                // Correcto3
            }
            if (txtCountdown.text == "4")
            {
                //   Correcto4
            }
            if (txtCountdown.text == "5")
            {
                // Correcto5
                Debug.Log("hola");
            }
            if (txtCountdown.text == "6")
            {
                // Correcto6
            }
            if (txtCountdown.text == "7")
            {
                // Correcto7
            }
            if (txtCountdown.text == "8")
            {
                //Correcto8
            }
            if (txtCountdown.text == "9")
            {
                //Correcto9
            }
            if (txtCountdown.text == "10")
            {
                //Correcto10
            }
            

        }
            
               
}

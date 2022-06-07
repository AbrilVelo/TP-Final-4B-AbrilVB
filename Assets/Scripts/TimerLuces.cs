using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerLuces : MonoBehaviour {
 
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
  


    // Use this for initialization
    void Start () {
        txtCountdown.text = counter.ToString();
        txtCountdown.text = Mathf.FloorToInt(Time.time).ToString();
    }
	
	// Update is called once per frame
	void Update () {
        for (counter = 0; counter > 0; counter++)
        {
            if (counter == 1)
            {
                //Correcto1. //cambiar color
            }
            if (counter == 2)
            {
                //Correcto2
            }
            if (counter == 3)
            {
                // Correcto3
            }
            if (counter == 4)
            {
                //   Correcto4
            }
            if (counter == 5)
            {
                // Correcto5
                Debug.Log("hola");
            }
            if (counter == 6)
            {
                // Correcto6
            }
            if (counter == 7)
            {
                // Correcto7
            }
            if (counter == 8)
            {
                //Correcto8
            }
            if (counter == 9)
            {
                //Correcto9
            }
            if (counter == 10)
            {
                //Correcto10
            }
            

        }
            
                }
}

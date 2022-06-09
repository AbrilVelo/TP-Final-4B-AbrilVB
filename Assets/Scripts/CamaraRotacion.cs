using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamaraRotacion : MonoBehaviour
{
    public Text txtCountdown;
    public GameObject empezarjugada;
    BoxCollider Bc;

    void Start()
    {

        Bc = empezarjugada.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (txtCountdown.text == "10")
        {
            empezarjugada.GetComponent<BoxCollider>().enabled = false;
        }

    }
    
}
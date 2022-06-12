using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamaraRotacion : MonoBehaviour
{
    // ESTE SCRIPT ES PARA QUE EL JUGADOR SOLO EMPIEZE A JUGAR A LOS 10 SEGUNDOS.
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
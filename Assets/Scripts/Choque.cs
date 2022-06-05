using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choque : MonoBehaviour
{
    public GameObject jugador;
    
    int puntos;
    public Text contador;

    void Start()
    {
        puntos = 0;
       
    }

    void Update()
    {

    }
   
    void OnCollisionEnter(Collision col)
    {
       if (col.gameObject.tag == "Ground")
        {
            jugador.transform.position = new Vector3(0, 0, 0);
            puntos++;
            contador.text = ("points: ") + (puntos -1);

        }
    }




}

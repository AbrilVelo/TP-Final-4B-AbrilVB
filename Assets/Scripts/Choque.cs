using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choque : MonoBehaviour
{
    public GameObject jugador;
    
    int puntos;
    public Text contador;
    public Text PerdisteTxt;

    void Start()
    {
        puntos = 0;
       
    }

    void Update()
    {
        if(puntos == 3)
        {
            PerdisteTxt.text = "Perdiste";
            contador.text = "";
        }
    }
   
    void OnCollisionEnter(Collision col)
    {
       if (col.gameObject.tag == "Ground")
        {
            jugador.transform.position = new Vector3(0, 0, 0);
           // jugador.transform.localScale = new Vector3(0, 0, 0);
            puntos++;
            contador.text = ("points: ") + (puntos);

        }
    }




}

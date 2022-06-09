using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choque : MonoBehaviour
{
    //ESTE SCRIPT ES PARA CUANDO EL JUGADOR SE CAE AL VACÍO: SE REINCIA SU POSICIÓN Y SE CUENTA 1 PUNTO.

    public GameObject jugador;
    public GameObject objectToClone;
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
            jugador.transform.position = new Vector3(0, 0.5F, 0);
            jugador.transform.localScale = new Vector3(1, 1, 1);
            jugador.transform.eulerAngles = new Vector3(0, 0, 0);
            puntos++;
            contador.text = ("points: ") + (puntos);

        }

       

        }

     void OnCollisionExit(Collision coll)
    {
        if(coll.gameObject.tag == "Respawn") 
        {
            Debug.Log("PERD");
                if (jugador.transform.position.y < -1)
                {
                
                int counter = 0;
                    while (counter < 3)
                        {
                    Debug.Log("h");
                        Instantiate(objectToClone);
                        counter++;
                         }
                }
        }
       
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choque : MonoBehaviour
{
    //ESTE SCRIPT ES PARA CUANDO EL JUGADOR SE CAE AL VACÍO: SE REINCIA SU POSICIÓN Y SE CUENTA 1 PUNTO.

    public GameObject jugador;
    public GameObject Bloquecitos;
    BoxCollider BoxCol;
    public GameObject objectToClone;
    int puntos;
    public Text contador;
    public Text PerdisteTxt;

    void Start()
    {
        puntos = 3;
        BoxCol = Bloquecitos.GetComponent<BoxCollider>();
    }

    void Update()
    {
        if(puntos == 0)
        {
            PerdisteTxt.text = "Perdiste";
            contador.text = ("Vidas: ");
        }
        
    }
   
    void OnCollisionEnter(Collision col)
    {
       if (col.gameObject.tag == "Ground")
        {
            jugador.transform.position = new Vector3(0, 0.5F, 0);
            jugador.transform.localScale = new Vector3(1, 1, 1);
            jugador.transform.eulerAngles = new Vector3(0, 0, 0);
            puntos--;
            contador.text = ("Vidas: ") + (puntos);
            Bloquecitos.GetComponent<BoxCollider>().enabled = true;
        }

        if (col.gameObject.tag == "Destruye")
        {
            jugador.transform.eulerAngles = new Vector3(0, 0, 0);
            int counter = 0;
            while (counter < 2)
            {
                
                Instantiate(objectToClone).transform.position = jugador.transform.position;
                counter++;
                Bloquecitos.GetComponent<BoxCollider>().enabled = false;
            }
           
        }


    }

}

     
        
     
       
    //}




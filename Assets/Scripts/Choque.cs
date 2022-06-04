using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choque : MonoBehaviour
{
    public GameObject jugador;
    public GameObject cubo;
    int puntos;
    public Text contador;

    void Start()
    {
        puntos = 0;
        //bool UseGravity = false;
    }

    void Update()
    {

    }
    void OnCollisionEnter()
    {
        jugador.transform.position = new Vector3(0, 0, 0);

        puntos = 1;
        contador.text = ("points: ") + puntos;

    }
    void OnCollisionEnter(Collision col)
    {
       if (col.gameObject.tag == "Cubos")
        {
           Destroy(cubo);
       }
    }




}

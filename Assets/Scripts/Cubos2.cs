using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cubos2 : MonoBehaviour
{

    //ESTE SCRIPT ES PARA LOS CUBOS, SI LOS TOCA EL PLAYER SE ACTIVA LA GRAVEDAD(PARA QUE CAIGAN)
    // SI TOCAN EL VACÍO, SE ELIMINAN

    Rigidbody rb;
    public GameObject cubo;
    public Text RandomCubos;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {

    }



    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Destruye")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
            if(RandomCubos.text == "1")
            {
            cubo.AddComponent<Rigidbody>();

            if (col.gameObject.name == "Player" || col.gameObject.tag == "Cubos")
             {
                rb.useGravity = true;
             }
            
            
            }
    }


}

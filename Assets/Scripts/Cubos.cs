using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubos : MonoBehaviour {

    //ESTE SCRIPT ES PARA LOS CUBOS, SI LOS TOCA EL PLAYER SE ACTIVA LA GRAVEDAD(PARA QUE CAIGAN)
    // SI TOCAN EL VACÍO, SE ELIMINAN

    Rigidbody rb;
   

    void Start () {

        rb = GetComponent<Rigidbody>();
    }
	
	
	void Update () {
		
	}

    

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
       {
            Destroy(gameObject);
       }
        if (col.gameObject.name == "Player")
        {
            rb.useGravity = true;
        }

    }
    
   
}

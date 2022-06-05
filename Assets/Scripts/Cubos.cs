using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubos : MonoBehaviour {

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

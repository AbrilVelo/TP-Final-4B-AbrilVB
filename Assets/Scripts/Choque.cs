using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choque : MonoBehaviour {
    public GameObject jugador;
	void Start () {
		
	}
	
	void Update () {
		 
	}
    void OnCollisionEnter()
    {
        jugador.transform.position = new Vector3(0, 0, 0);
    }
}

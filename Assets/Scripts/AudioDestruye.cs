using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDestruye : MonoBehaviour {

    public AudioClip Muerte;
    public AudioClip CubosDestruye;
    AudioSource PlayerDestruido;
    AudioSource CuboDestruido;

    void Start()
    {

        PlayerDestruido = GetComponent<AudioSource>();
        CuboDestruido = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "Player")
        {
            PlayerDestruido.clip = Muerte;
            PlayerDestruido.Play();
        }
        if (col.gameObject.tag == "Cubos" )
        {
            CuboDestruido.clip = CubosDestruye;
            CuboDestruido.Play();
        }
    }
   
}

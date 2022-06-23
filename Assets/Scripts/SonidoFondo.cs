using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoFondo : MonoBehaviour
{

    public AudioClip Musica;
    AudioSource Audio;
    
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.clip = Musica;
        Audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

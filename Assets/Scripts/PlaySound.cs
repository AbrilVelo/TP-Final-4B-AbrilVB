using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    
    public AudioClip Salto;
    AudioSource fuenteAudio;
    

    void Start () {
        fuenteAudio = GetComponent<AudioSource>();
       

    }

   
        void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fuenteAudio.clip = Salto;
            fuenteAudio.Play();
        }
    }
}

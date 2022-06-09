using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementPlayer : MonoBehaviour
{
    //ESTE SCRIPT ES PARA EL MOVIMIETNO DEL PLAYER Y SU SALTO.

    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public int maxJumps;
    public GameObject jugador;
    public GameObject camara;

    int hasJump;
    Rigidbody rb;
    float CamaraY = 90.58401f;
    float CamaraX = 33.382f;

    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
        //float PosicionCorrecta = transform.eulerAngles = new Vector3(0, 0, 0);
        
    }
    void Update()
    {

       
        
        

        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(movementSpeed, 0, 0); 
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) )
        {
            // hasJump == maxJumps
            //transform.Rotate(0, rotationSpeed, 0);
            transform.position -= new Vector3(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //  || hasJump == maxJumps
            // transform.Rotate(0, -rotationSpeed, 0);
            transform.position -= new Vector3(0, 0, -movementSpeed); 
        }
        if (Input.GetKeyDown(KeyCode.Space) && hasJump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            hasJump--;
        }

    }
        void OnCollisionEnter(Collision col)
        {
             if (col.gameObject.tag == "Respawn") 
             {
                hasJump = maxJumps;
                jugador.transform.eulerAngles = new Vector3(0, 0, 0);
            if (camara.transform.eulerAngles != new Vector3(CamaraX,CamaraY,0))
            {
                              camara.transform.eulerAngles = new Vector3(CamaraX, CamaraY, 0);
                         }
        }
            if (col.gameObject.tag == "Finish")
            {
            SceneManager.LoadScene("Ganaste");
            
            }
            if (col.gameObject.tag == "Cubos" || col.gameObject.tag == "Finish")
        {
                hasJump = maxJumps;
                        if (camara.transform.eulerAngles != new Vector3(CamaraX, CamaraY, 0))
            {
                camara.transform.eulerAngles = new Vector3(CamaraX, CamaraY, 0);
                        }
        }
    }
    


}

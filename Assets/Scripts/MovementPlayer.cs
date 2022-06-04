using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{

    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public int maxJumps;

    int hasJump;
    Rigidbody rb;

    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(hasJump == 0)
        {
            hasJump = 1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D) && hasJump == maxJumps)
        {
            transform.Rotate(0, rotationSpeed, 0);
            transform.position -= new Vector3(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.A) && hasJump == maxJumps)
        {
            transform.Rotate(0, -rotationSpeed, 0);
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
             if (col.gameObject.tag == "ground")
        {
                hasJump = maxJumps;
        }
    }

}

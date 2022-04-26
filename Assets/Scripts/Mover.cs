using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float velocity = 10f;

    Rigidbody myRigidbody = null;

    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            myRigidbody.velocity = Vector3.forward * velocity * Input.GetAxis("Vertical") * Time.deltaTime;
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            myRigidbody.velocity = Vector3.right * velocity * Input.GetAxis("Horizontal") * Time.deltaTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fleeTarget : MonoBehaviour
{

    public Transform target;
    private Rigidbody rb;

    public float speed = 5;
    public float rotateSpeed = 200f;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(target);
        transform.position -= transform.forward * speed * Time.deltaTime;
    }
}

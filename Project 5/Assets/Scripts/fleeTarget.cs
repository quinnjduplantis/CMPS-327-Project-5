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
        //Vector3 direction = target.position - rb.position;
        //direction.Normalize();
        var rotateAmount = Quaternion.LookRotation(target.position - transform.position);
        rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, rotateAmount, rotateSpeed));
        rb.velocity = -transform.forward * speed;
    }
}

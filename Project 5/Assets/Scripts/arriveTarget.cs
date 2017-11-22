using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arriveTarget : MonoBehaviour {

    public Transform target;

    public float speed = 5;
    public float rotateSpeed = 200f;


	// Use this for initialization
	void Start () {
         
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.LookAt(target);
        transform.position += transform.forward * speed * Time.deltaTime;
	}
}
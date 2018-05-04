﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour {
	public float speed = 10.0f;
    public Rigidbody rb;
 
    void Start(){
            rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		float x =  Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;
        rb.AddForce(x , 0 , z );	
	}
}

﻿using UnityEngine;
using System.Collections;
 
public class Wind : MonoBehaviour {
    public float coefficient;   // 空気抵抗係数
    public Vector3 velocity;    // 風速
 
	void OnTriggerStay(Collider col) {
        if ( col.GetComponent<Rigidbody>() == null ) {
            return;
        }
 
        // 相対速度計算
        var relativeVelocity = velocity - col.rigidbody.velocity;
 
	    // 空気抵抗を与える
        col.rigidbody.AddForce(coefficient * relativeVelocity);
	}
}

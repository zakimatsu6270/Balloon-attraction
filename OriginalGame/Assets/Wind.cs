using UnityEngine;
using System.Collections;
 
public class Wind : MonoBehaviour {
    public float coefficient = 0;   // 空気抵抗係数
    public Vector3 velocity = new Vector3(0,5,5);    // 風速
 
	void OnTriggerStay(Collider col) {
        if ( col.GetComponent<Rigidbody>() == null ) {
            return;
        }
 
        // 相対速度計算
        var relativeVelocity = velocity - col.GetComponent<Rigidbody>().velocity;
 
	    // 空気抵抗を与える
        col.GetComponent<Rigidbody>().AddForce(coefficient * relativeVelocity);
	}
}

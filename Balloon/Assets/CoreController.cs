using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreController : MonoBehaviour {
    public GameObject target;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < 2.42){
        transform.position = target.transform.position + new Vector3(0,0,-2.0f);
		//transform.Translate(new Vector3(0,0,Time.deltaTime),Camera.main.transform);
		//gameObject.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0);
		}
		if(Input.GetKey ("up")) {
			transform.position += new Vector3(0,0,speed*Time.deltaTime);
		}
		if(Input.GetKey ("down")) {
			transform.position += new Vector3(0,0,-speed*Time.deltaTime);
		}
		if(Input.GetKey ("left")) {
			if(Input.GetKey(KeyCode.Space)){
				transform.Rotate(0,-30*speed*Time.deltaTime,0);
			} else {
				transform.position += new Vector3(-speed*Time.deltaTime,0,0);
			}
		}
		if(Input.GetKey ("right")) {
			if(Input.GetKey(KeyCode.Space)){
				transform.Rotate(0,30*speed*Time.deltaTime,0);
			} else {
				transform.position += new Vector3(speed*Time.deltaTime,0,0);
			}
		}
		//this.transform.Rotate ( 0, ( Input.GetAxis ( "Horizontal" ) * 1 ), 0 );
	}
}

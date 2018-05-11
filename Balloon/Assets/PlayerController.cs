using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public GameObject Balloon;
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Balloon.transform.position.y < 3.45){
			transform.position = Balloon.transform.position + new Vector3(0,0,-4.0f);
		}
		if(3.95< Balloon.transform.position.y && Balloon.transform.position.y < 8.4){
			transform.position = Balloon.transform.position + new Vector3(0,0,-4.0f);
			Debug.Log ("A");
		}
		if(Input.GetKey ("up")) {
			//transform.position += new Vector3(0,0,speed*Time.deltaTime);
			transform.Translate(new Vector3(0,0,Time.deltaTime),Camera.main.transform);
			Debug.Log ("Go");
		}
		if(Input.GetKey ("down")) {
			//transform.position += new Vector3(0,0,-speed*Time.deltaTime);
			transform.Translate(new Vector3(0,0,-Time.deltaTime),Camera.main.transform);
			Debug.Log ("Back");
		}
		if(Input.GetKey ("left")) {
			if(Input.GetKey(KeyCode.Space)){
				transform.Rotate(0,-30*speed*Time.deltaTime,0);
				Debug.Log ("left turn");
			} else {
				//transform.position += new Vector3(-speed*Time.deltaTime,0,0);
				transform.Translate(new Vector3(-Time.deltaTime,0,0),Camera.main.transform);
				Debug.Log("left");
			}
		}
		if(Input.GetKey ("right")) {
			if(Input.GetKey(KeyCode.Space)){
				transform.Rotate(0,30*speed*Time.deltaTime,0);
				Debug.Log ("right turn");
			} else {
				//transform.position += new Vector3(speed*Time.deltaTime,0,0);
				transform.Translate(new Vector3(Time.deltaTime,0,0),Camera.main.transform);
				Debug.Log("right");
			}
		}
		//this.transform.Rotate ( 0, ( Input.GetAxis ( "Horizontal" ) * 1 ), 0 );
	}
}

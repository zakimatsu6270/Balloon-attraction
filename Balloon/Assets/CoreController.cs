using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreController : MonoBehaviour {
    public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.transform.position + new Vector3(0,2.0f,4.0f);
		//transform.Translate(new Vector3(0,0,Time.deltaTime),Camera.main.transform);
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour {

	void OnTriggerEnter(Collider on) {
		if (on.gameObject.tag == "Goal"){
			Debug.Log("B");
    		SceneManager.LoadScene("Clear");
		}
	}
}
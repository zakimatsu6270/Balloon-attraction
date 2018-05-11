using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void OnTriggerEnter(Collider put) {
		if (put.gameObject.tag == "floor"){
			Debug.Log("B");
    		SceneManager.LoadScene("GameOver");
		}
	}
}
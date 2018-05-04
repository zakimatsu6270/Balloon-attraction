using UnityEngine;
using System.Collections;
 
public class WindController : MonoBehaviour {
  	public float velocity; // 風速
 
  	private GameObject core;
 
  	// Use this for initialization
  	void Start () {

	}
 
  	// Update is called once per frame
  	void Update () {

	}
 
  	void OnTriggerStay(Collider hit) {
    	if (hit.gameObject.tag == "Player") {
      		// 風力を与える
      		Vector3 direction = hit.transform.position - core.transform.position; // 方向
      		float distance = Vector3.Distance(hit.transform.position, core.transform.position); // 相対距離
      		float drag = hit.GetComponent<Rigidbody>().drag; // 空気抵抗
 			hit.GetComponent<Rigidbody>().AddForce(direction * drag * velocity / distance, ForceMode.Force);
    	}
	}
}

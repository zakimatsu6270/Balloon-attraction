using UnityEngine;
using System.Collections;

//class CameraController : MonoBehaviour {
//	public GameObject target;

	// Use this for initialization
//	void Start () {
		
//	}
	
	// Update is called once per frame
//	void Update () {
//		transform.position = target.transform.position + new Vector3(0,-1.0f,-4.0f);
//		transform.rotation = target.transform.rotation;
//	}
//}

public class CameraController : MonoBehaviour {
   	public GameObject Center;
	private Vector3 lastMousePosition;
  	private Vector3 newAngle = new Vector3(0, 0, 0);
	
	void start (){
		
	}

 	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            // マウスクリック開始(マウスダウン)時にカメラの角度を保持(Z軸には回転させないため).
            newAngle = Center.transform.localEulerAngles;
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            // マウスの移動量分カメラを回転させる.
            newAngle.y -= (Input.mousePosition.x - lastMousePosition.x) * 0.1f;
            newAngle.x -= (Input.mousePosition.y - lastMousePosition.y) * 0.1f;
            Center.gameObject.transform.localEulerAngles = newAngle;

            lastMousePosition = Input.mousePosition;
        }
	}
}

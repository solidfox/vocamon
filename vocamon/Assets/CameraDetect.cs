using UnityEngine;
using System.Collections;

public class CameraDetect : MonoBehaviour {

	public Camera C;
	void OnTriggerEnter(Collider other){
		Debug.Log ("Enter trigger QQ ");
	}
	
	void OnTriggerStay(Collider other){
		Debug.Log ("Trigger stay QQ");
	}
	
	void OnTriggerExit(Collider other){
		Debug.Log ("Trigger Exit QQ");
		//C.isActiveAndEnabled = false;
	}
}

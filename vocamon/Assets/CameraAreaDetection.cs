using UnityEngine;
using System.Collections;

public class CameraAreaDetection : MonoBehaviour {
	public Camera C;
	void OnTriggerEnter(Collider other){
		Debug.Log ("Enter trigger XD ");
	}
	
	void OnTriggerStay(Collider other){
		Debug.Log ("Trigger stay XD");
	}
	
	void OnTriggerExit(Collider other){
		Debug.Log ("Trigger Exit XD");
		//C.isActiveAndEnabled = false;
	}
}

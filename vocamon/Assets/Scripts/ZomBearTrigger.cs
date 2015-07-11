using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ZomBearTrigger : MonoBehaviour {
	public Text MainText;
	public CanvasGroup MainCanvasGroup;
	void OnTriggerEnter(Collider other){
		MainText.text = "I am Bear keke XDD";
		MainCanvasGroup.alpha = 1;
	}
	
	void OnTriggerStay(Collider other){
		
	}
	
	void OnTriggerExit(Collider other){
		MainText.text = "";
		MainCanvasGroup.alpha = 0;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPorta4 : MonoBehaviour {

	public GameObject portaFour;
	public GameObject fourthWall;

	// Cuarta puerta
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag(tag: "porta4")) {
			fourthWall.SetActive(false);
			portaFour.SetActive(false);
		}  
	}


}

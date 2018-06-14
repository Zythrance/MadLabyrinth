using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPorta3 : MonoBehaviour {

	public GameObject portaThree;
	public GameObject thirdWall;

	// Tercera puerta
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag(tag: "porta3")) {
			thirdWall.SetActive(false);
			portaThree.SetActive(false);
		}  
	}


}

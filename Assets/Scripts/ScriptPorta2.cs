using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPorta2 : MonoBehaviour {

	public GameObject portaTwo;
	public GameObject secondWall;

	// Segunda puerta
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag(tag: "porta2")) {
			secondWall.SetActive(false);
			portaTwo.SetActive(false);
		}  
	}


}

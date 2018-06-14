using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReset : MonoBehaviour {

	public AudioClip golpiado;
	private AudioSource source;
	

	void OnTriggerEnter(Collider other) {

		if(other.gameObject.CompareTag("EnemyRed")) {
			transform.position = new Vector3 (1,1,1);
			source.PlayOneShot(golpiado);

		}

	}
}
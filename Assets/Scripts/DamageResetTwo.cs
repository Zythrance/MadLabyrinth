using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageResetTwo : MonoBehaviour {

	public AudioClip golpiado;
	private AudioSource source;


	void OnTriggerEnter(Collider other) {

		if(other.gameObject.CompareTag("EnemyRedTwo")) {
			transform.position = new Vector3 (147.9146f,2,50.36906f);
			source.PlayOneShot(golpiado);

		}

	}
}
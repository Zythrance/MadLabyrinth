using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageResetThree : MonoBehaviour {

	public AudioClip golpiado;
	private AudioSource source;


	void OnTriggerEnter(Collider other) {

		if(other.gameObject.CompareTag("EnemyRedThree")) {
			transform.position = new Vector3 (712.129f,2.000004f,0.4835725f);
			source.PlayOneShot(golpiado);

		}

	}
}
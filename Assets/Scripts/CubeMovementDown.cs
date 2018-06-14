using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovementDown : MonoBehaviour {

	public float frequency = 1f;    //movement speed
	public float amplitude = 1f;    //movement amount
	Vector3 startPos;
	float elapsedTime = 0f;
	// Use this for initialization
	void Start()
	{
		startPos = transform.position;
	}
	// Update is called once per frame
	void Update()
	{
		elapsedTime += Time.deltaTime * Time.timeScale * frequency;
		transform.position = startPos + Vector3.forward * Mathf.Sin(elapsedTime) * amplitude;
	}


}
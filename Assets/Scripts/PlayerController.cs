using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed = 1.0f;
    public GameObject porta;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(x, 0.0f, z);
        rb.AddForce(force * speed);

        
    }

	// Primera puerta
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag(tag: "porta")) {
            other.gameObject.SetActive(false);
			porta.SetActive(false);
        }  
    }

}
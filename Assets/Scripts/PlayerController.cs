using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float jumForce = 7;
    public Rigidbody rb;
    public BoxCollider col;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            rb.AddForce(Vector3.up * jumForce, ForceMode.Impulse);
        }
    }
}

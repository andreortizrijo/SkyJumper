using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{

    private float movSpeed = 7f;
    private float jumForce = 3f;

    private bool change;

    public Rigidbody rb;
    public BoxCollider col;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        transform.Translate(movSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            rb.AddForce(Vector3.up * jumForce, ForceMode.Impulse);
        }
    }
}

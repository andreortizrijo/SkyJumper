using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour {

    private float movSpeed = 10f;
    private float jumForce = 10f;

    public bool change;

    public Rigidbody2D rb;
    public BoxCollider2D col;

    public GameObject coinPoitns;
    private int result = 10;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        transform.Translate(movSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }

    // Flip the character Image
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            rb.AddForce(Vector3.up * jumForce, ForceMode2D.Impulse);

            if (change)
            {
                change = false;
                this.GetComponent<SpriteRenderer>().flipX = change;
            }
            else if(change == false)
            {
                change = true;
                this.GetComponent<SpriteRenderer>().flipX = change;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Coin")
        {
            //coinPoitns.GetComponent<Text>().text = result.ToString();
            Destroy(collision.gameObject);
        }
    }
}

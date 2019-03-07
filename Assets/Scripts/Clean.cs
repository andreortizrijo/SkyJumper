using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clean : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }
}   

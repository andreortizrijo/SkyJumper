using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clean : MonoBehaviour
{
    [SerializeField] private Transform deathPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            Destroy(collision.gameObject);
        }

        if (collision.transform.tag == "Player")
        {
            collision.transform.position = deathPoint.transform.position;
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

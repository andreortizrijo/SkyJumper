using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player;
    private float camSpeed = 0.1f;

	// Use this for initialization
	void Start () {
        player = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (player)
        {
            transform.position = Vector3.Lerp(transform.position, player.position, camSpeed) + new Vector3(0, 0, -10);
        }
    }
}

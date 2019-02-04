using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject plat;
    public Transform[] spawnPoints;


	// Use this for initialization
	void Start () {
        StartCoroutine(spawnPalt());
	}
	
	IEnumerator spawnPalt()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);


            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            Instantiate(plat, spawnPoint.position, spawnPoint.rotation);


        }
    }
}

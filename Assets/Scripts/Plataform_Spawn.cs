using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform_Spawn : MonoBehaviour
{
    public Camera Cam = new Camera();
    public bool isLive = true;
    public float maxwidth;
    public GameObject[] objecto;

    public GameObject startPoint;
    public GameObject deathPoint;
    public GameObject playerPos;

    public void StartGame()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 UpperC = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 largura = Cam.ScreenToWorldPoint(UpperC);
        maxwidth = largura.x - objecto[0].GetComponent<Renderer>().bounds.extents.x;

        if (playerPos.transform.position == deathPoint.transform.position)
        {
            isLive = false;
        }
        else if(playerPos.transform.position == startPoint.transform.position)
        {
            isLive = true;
        }

    }

    IEnumerator Spawn()
    {

        while (isLive)
        {

            Vector3 spawnposition = new Vector3(Random.Range(-maxwidth, maxwidth), transform.position.y, 0.0f);
            if (Random.Range(0, 2) == 0)
            {
                Instantiate(objecto[Random.Range(0, objecto.Length)], spawnposition, Quaternion.identity);
            }
            else
            {
                Instantiate(objecto[Random.Range(0, objecto.Length)], spawnposition, Quaternion.identity);
            }
            yield return new WaitForSeconds(1.0f);
        }

    }
}
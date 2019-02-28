using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform_Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2.0f);
        GameObject bola;
        while (timeleft > 0)
        {
            timerText.text = "Timer Left: \n" + timeleft;
            Vector3 spawnposition = new Vector3(Random.Range(-maxwidth, maxwidth), transform.position.y, 0.0f);
            Instantiate(objecto[Random.Range(0, objecto.Length)], spawnposition, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }
        yield return new WaitForSeconds(2.0f);
        Gameover.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        btnRestart.SetActive(true);
    }
}

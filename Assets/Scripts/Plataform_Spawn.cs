using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform_Spawn : MonoBehaviour
{
    public Camera Cam = new Camera();
    public bool isLive = true;
    public float maxwidth;
    public GameObject[] objecto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 UpperC = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 largura = Cam.ScreenToWorldPoint(UpperC);
        maxwidth = largura.x - objecto[0].GetComponent<Renderer>().bounds.extents.x;
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2.0f);
        
        while (isLive)
        {
            Vector3 spawnposition = new Vector3(Random.Range(-maxwidth, maxwidth), transform.position.y, 0.0f);
            Instantiate(objecto[Random.Range(0, objecto.Length)], spawnposition, Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
     
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroidorDeMundos : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        if(col.gameObject.tag == "Player")
        {
            Plataform_Spawn plataform = new Plataform_Spawn();
            plataform.isLive = false;
            
        }
    }

}

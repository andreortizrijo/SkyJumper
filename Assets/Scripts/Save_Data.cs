using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Save_Data : MonoBehaviour
{
    public int coinEarned;

    public Save_Data(PlayerController player)
    {
        coinEarned = player.coin;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Save_Data : MonoBehaviour
{
    public int coinEarned;
    public SpriteRenderer charecterSprite;

    public Save_Data(PlayerController player)
    {
        coinEarned = player.coin;
        //charecterSprite = player.characterSprite;
    }

}

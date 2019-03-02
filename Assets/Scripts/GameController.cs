using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Menu")]
    public GameObject gameImage;
    public GameObject startButton;
    public GameObject scoreButton;
    public GameObject storeButton;
    public GameObject quitButton;
    public GameObject rewardButton;

    [Header("Score")]


    [Header("Store")]


    [Header("Values")]
    public int coin;
    public int score;

    public void OpenStore()
    {
        gameImage.SetActive(false);
        startButton.SetActive(false);
        scoreButton.SetActive(false);
        storeButton.SetActive(false);
        quitButton.SetActive(false);
        rewardButton.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Menu")]
    public GameObject gameImage;
    public GameObject startButton;
    public GameObject storeButton;
    public GameObject quitButton;
    public GameObject rewardButton;

    public GameObject coinInfo;

    [Header("Store")]
    public GameObject previewImage;
    public GameObject previousButton;
    public GameObject nextButton;
    public GameObject buyButton;
    //public GameObject backButton;

    [Header("Values")]
    public int coin;
    public int score;
    public int rewardValue;
    
    public void Start()
    {
        coinInfo.GetComponent<Text>().text = coin.ToString();
    }

    public void StartGame()
    {
        //Hidde Menu UI
        gameImage.SetActive(false);
        startButton.SetActive(false);
        storeButton.SetActive(false);
        quitButton.SetActive(false);
        rewardButton.SetActive(false);

        //Show Game UI
    }

    public void OpenStore()
    {
        //Hidde Menu UI
        gameImage.SetActive(false);
        startButton.SetActive(false);
        storeButton.SetActive(false);
        quitButton.SetActive(false);
        rewardButton.SetActive(false);

        //Show Store UI
        previewImage.SetActive(true);
        previousButton.SetActive(true);
        nextButton.SetActive(true);
        buyButton.SetActive(true);
        //backButton.SetActive(true);
    }

    public void claimReward(int rewardValueue)
    {
        coin = coin + rewardValue;
        coinInfo.GetComponent<Text>().text = coin.ToString();
    }
}

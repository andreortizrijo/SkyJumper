using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Game")]
    public GameObject characte;
    public GameObject cOin;
    public GameObject plataforma;

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
    public GameObject backButton;

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
        characte.SetActive(true);
        cOin.SetActive(true);
        plataforma.SetActive(true);
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
        backButton.SetActive(true);
    }

    public void CloseStore()
    {
        //Hidde Store UI
        gameImage.SetActive(true);
        startButton.SetActive(true);
        storeButton.SetActive(true);
        quitButton.SetActive(true);
        rewardButton.SetActive(true);

        //Show Menu UI
        previewImage.SetActive(false);
        previousButton.SetActive(false);
        nextButton.SetActive(false);
        buyButton.SetActive(false);
        backButton.SetActive(false);
    }

    public void claimReward(int rewardValueue)
    {
        coin = coin + rewardValue;
        coinInfo.GetComponent<Text>().text = coin.ToString();
    }

    private void Update()
    {
        coinInfo.GetComponent<Text>().text = coin.ToString();
    }

    public void Quit()
    {
        Application.Quit();
    }

}

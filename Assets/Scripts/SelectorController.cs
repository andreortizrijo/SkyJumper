using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SelectorController : MonoBehaviour
{
    private int i = 0;
    public bool[] isUnlocked;

    public GameObject character;

    public GameObject coinImage;
    public GameObject charPrice;
    public GameObject selectedText;
    public GameObject imagePreview;
    public GameObject buyButton;
    public Sprite[] characters;

    private GameController coin;
    private int result;

    private void Start()
    {
        imagePreview.GetComponent<Image>().sprite = characters[0];
    }

    public void NextCharacter()
    {
        if (i == characters.Length - 1)
        {
            i = 0;
            if(isUnlocked[i] == true)
            {
                coinImage.SetActive(false);
                charPrice.SetActive(false);
                selectedText.SetActive(true);
            }
            else
            {
                coinImage.SetActive(true);
                charPrice.SetActive(true);
                selectedText.SetActive(false);
            }
        }
        else
        {
            i++;
            if (isUnlocked[i] == true)
            {
                coinImage.SetActive(false);
                charPrice.SetActive(false);
                selectedText.SetActive(true);
            }
            else
            {
                coinImage.SetActive(true);
                charPrice.SetActive(true);
                selectedText.SetActive(false);
            }
        }
        imagePreview.GetComponent<Image>().sprite = characters[i];

    }

    public void PreviousCharacter()
    {
        if (i == 0)
        {
            i = characters.Length - 1;
            if (isUnlocked[i] == true)
            {
                coinImage.SetActive(false);
                charPrice.SetActive(false);
                selectedText.SetActive(true);
            }
            else
            {
                coinImage.SetActive(true);
                charPrice.SetActive(true);
                selectedText.SetActive(false);
            }
        }
        else
        {
            i--;
            if (isUnlocked[i] == true)
            {
                coinImage.SetActive(false);
                charPrice.SetActive(false);
                selectedText.SetActive(true);
            }
            else
            {
                coinImage.SetActive(true);
                charPrice.SetActive(true);
                selectedText.SetActive(false);
            }
        }
        imagePreview.GetComponent<Image>().sprite = characters[i];
    }

    public void BuyChar()
    {
        if (i == 0)
        {
            character.GetComponent<SpriteRenderer>().sprite = characters[i];
            character.transform.localScale = new Vector3(3f, 3f, 3f);
            character.GetComponent<BoxCollider2D>().offset = new Vector2(0.1395913f, 0.1352972f);
        }
        else if(i == 1)
        {
            character.GetComponent<SpriteRenderer>().sprite = characters[i];
            character.transform.localScale = new Vector3(0.27f, 0.27f, 0.27f);
            character.GetComponent<BoxCollider2D>().offset = new Vector2(0.1395913f, 0.1352972f);
        }
        else if (i == 2)
        {
            character.GetComponent<SpriteRenderer>().sprite = characters[i];
            character.transform.localScale = new Vector3(2f, 2f, 2f);
            character.GetComponent<BoxCollider2D>().offset = new Vector2(0.1395913f, 0.1352972f);
        }
    }
   
}

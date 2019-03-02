using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SelectorController : MonoBehaviour
{
    private int i = 0;
    
    public GameObject imagePreview;
    public Sprite[] characters;

    private void Start()
    {
        imagePreview.GetComponent<Image>().sprite = characters[0];
    }

    public void NextCharacter()
    {
        if (i == characters.Length - 1)
        {
            i = 0;
        }
        else
        {
            i++;
        }
        imagePreview.GetComponent<Image>().sprite = characters[i];

    }

    public void PreviousCharacter()
    {
        if (i == 0)
        {
            i = characters.Length - 1;
        }
        else
        {
            i--;
        }
        imagePreview.GetComponent<Image>().sprite = characters[i];
    }
}

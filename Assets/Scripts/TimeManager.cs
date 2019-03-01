using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    public static TimeManager sharedInstance = null;
    private string _url = "http://tomasfernandes.pt/Beta/getTime.php";
    private string _timeData;
    private string _currentTime;
    private string _currentDate;


    void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
        else if (sharedInstance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }


    public IEnumerator getTime()
    {
        Debug.Log("==> step 1. Getting info from internet now!");
        WWW www = new WWW(_url);
        yield return www;
        Debug.Log("==> step 2. Got the info from internet!");
        _timeData = www.text;
        string[] words = _timeData.Split('/');
        Debug.Log("The date is : " + words[0]);
        Debug.Log("The time is : " + words[1]);

        _currentDate = words[0];
        _currentTime = words[1];
    }


    void Start()
    {
        Debug.Log("==> TimeManager script is Ready.");
        StartCoroutine("getTime");
    }

    //get the current date
    public string getCurrentDateNow()
    {
        return _currentDate;
    }


    //get the current Time
    public string getCurrentTimeNow()
    {
        return _currentTime;
    }


}
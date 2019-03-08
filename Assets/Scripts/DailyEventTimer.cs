using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyEventTimer : MonoBehaviour
{
    [Header("UI")]
    public Text timeLabel;
    public Button timerButton;
    public Image _progress;

    [Header("Time Elements")]
    public int hours; 
    public int minutes; 
    public int seconds; 
    private bool _timerComplete = false;
    private bool _timerIsReady;
    private TimeSpan _startTime;
    private TimeSpan _endTime;
    private TimeSpan _remainingTime;
    
    [Header("Progress Filler")]
    private float _value = 1f;

    void Start()
    {
        if (PlayerPrefs.GetString("_timer") == "")
        {
            enableButton();
        }
        else
        {
            disableButton();
            StartCoroutine("CheckTime");
        }
    }
    
    private void updateTime()
    {
        if (PlayerPrefs.GetString("_timer") == "Standby")
        {
            PlayerPrefs.SetString("_timer", TimeManager.sharedInstance.getCurrentTimeNow());
            PlayerPrefs.SetInt("_date", TimeManager.sharedInstance.getCurrentDateNow());
        }
        else if (PlayerPrefs.GetString("_timer") != "" && PlayerPrefs.GetString("_timer") != "Standby")
        {
            int _old = PlayerPrefs.GetInt("_date");
            int _now = TimeManager.sharedInstance.getCurrentDateNow();
            
            if (_now > _old)
            {
                enableButton();
                return;
            }
            else if (_now == _old)
            { 
                _configTimerSettings();
                return;
            }
            else
            {
                Debug.Log("error with date");
                return;
            }
        }
        Debug.Log("Day had passed - configuring now");
        _configTimerSettings();
    }
    
    private void _configTimerSettings()
    {
        _startTime = TimeSpan.Parse(PlayerPrefs.GetString("_timer"));
        _endTime = TimeSpan.Parse(hours + ":" + minutes + ":" + seconds);
        TimeSpan temp = TimeSpan.Parse(TimeManager.sharedInstance.getCurrentTimeNow());
        TimeSpan diff = temp.Subtract(_startTime);
        _remainingTime = _endTime.Subtract(diff);
        
        setProgressWhereWeLeftOff();

        if (diff >= _endTime)
        {
            _timerComplete = true;
            enableButton();
        }
        else
        {
            _timerComplete = false;
            disableButton();
            _timerIsReady = true;
        }
    }
    
    private void setProgressWhereWeLeftOff()
    {
        float totalSeconds = 1f / (float)_endTime.TotalSeconds;
        float remainingTime = 1f / (float)_remainingTime.TotalSeconds;
        _value = totalSeconds / remainingTime;
        _progress.fillAmount = _value;
    }
    
    private void enableButton()
    {
        timerButton.interactable = true;
        timeLabel.text = "CLAIM REWARD";
    }

    private void disableButton()
    {
        timerButton.interactable = false;
        timeLabel.text = "REWARD CLAIMED";
    }

    private IEnumerator CheckTime()
    {
        disableButton();
        yield return StartCoroutine(
            TimeManager.sharedInstance.getTime()
        );
        updateTime();

    }


    public void rewardClicked()
    {

        PlayerPrefs.SetString("_timer", "Standby");
        StartCoroutine("CheckTime");
    }
    
    void Update()
    {
        if (_timerIsReady)
        {
            if (!_timerComplete && PlayerPrefs.GetString("_timer") != "")
            {
                _value -= Time.deltaTime * 1f / (float)_endTime.TotalSeconds;
                _progress.fillAmount = _value;
                
                if (_value <= 0 && !_timerComplete)
                {
                    validateTime();
                    _timerComplete = true;
                }
            }
        }
    }
    
    private void validateTime()
    {
        StartCoroutine("CheckTime");
    }
}
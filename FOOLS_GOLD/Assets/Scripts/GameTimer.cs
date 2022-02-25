using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] EndMenu endMenu;
    [SerializeField] GameObject hud;
    [SerializeField] GameManager gameManager;
    [SerializeField] float timeStart = 5f;

    public float timeLeft;
    public bool gameOver;
    Image gameTimer;

    void Awake()
    {
        gameTimer = GameObject.Find("GameTimer_Image").GetComponent<Image>();
    }

    void Start()
    {
        StartTimer();
    }

    void Update()
    {
        RunningTimer();
    }

    public void StartTimer()
    {
        timeLeft = timeStart;
        gameOver = false;
    }


    public void RunningTimer()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            gameTimer.fillAmount = timeLeft / timeStart;
        }
        else
        {
            Time.timeScale = 0;
            gameOver = true;
        }
    }
}

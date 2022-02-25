using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] Canvas endMenu;
    [SerializeField] Canvas hud;
    [SerializeField] float gameTime = 30f;

    public float timeLeft;
    Image gameTimer;

    void Awake()
    {
        gameTimer = GameObject.Find("GameTimer_Image").GetComponent<Image>();
    }

    void Start()
    {        
        timeLeft = gameTime;
    }

    void Update()
    {
        Timer();
    }

    public void Timer()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            gameTimer.fillAmount = timeLeft / gameTime;
        }
        else
        {
            Time.timeScale = 0;
            hud.enabled = false;
            endMenu.enabled = true;
            

        }
    }
}

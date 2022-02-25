using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] GameObject endScreen;   
    [SerializeField] float gameTime = 30f;
    public float timeLeft;
    Image gameTimer;

    void Awake()
    {
        //endScreen = GameObject.Find("EndMenu").GetComponent<Canvas>();
        gameTimer = GetComponent<Image>();
    }

    void Start()
    {        
        timeLeft = gameTime;
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            gameTimer.fillAmount = timeLeft / gameTime;
        }
        else
        {
            // timesUpText.SetActive(true);
            Time.timeScale = 0;
            // PUT ENDSCREEN TRANSITION HERE (JUST MAKE IT VISIBLE AND GAME INVISIBLE)
        }
    }
}

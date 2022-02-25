using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] EndMenu endMenu;
    [SerializeField] GameObject hud;
    [SerializeField] GameManager gameManager;
    [SerializeField] float timeStart = 5f;

=======
    [SerializeField] GameObject endScreen;   
    [SerializeField] float gameTime = 30f;
>>>>>>> parent of 99afccf (functional game timer implemented)
    public float timeLeft;
    public bool gameOver;
    Image gameTimer;

    void Awake()
    {
        //endScreen = GameObject.Find("EndMenu").GetComponent<Canvas>();
        gameTimer = GetComponent<Image>();
    }

    void Start()
    {
        StartTimer();
    }

    void Update()
    {
<<<<<<< HEAD
        RunningTimer();
    }

    public void StartTimer()
    {
        timeLeft = timeStart;
        gameOver = false;
    }


    public void RunningTimer()
    {
=======
>>>>>>> parent of 99afccf (functional game timer implemented)
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            gameTimer.fillAmount = timeLeft / timeStart;
        }
        else
        {
            // timesUpText.SetActive(true);
            Time.timeScale = 0;
<<<<<<< HEAD
            gameOver = true;
=======
            // PUT ENDSCREEN TRANSITION HERE (JUST MAKE IT VISIBLE AND GAME INVISIBLE)
>>>>>>> parent of 99afccf (functional game timer implemented)
        }
    }
}

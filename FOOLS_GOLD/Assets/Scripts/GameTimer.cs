using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] GameObject endScreen;   
    [SerializeField] float gameTime = 30f;
=======
    [SerializeField] Canvas endMenu;
    [SerializeField] Canvas hud;
    [SerializeField] float gameTime = 30f;

>>>>>>> parent of 47c6855 (bug fixes; all good except replay timer bug still NEEDS to be fixed;;)
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
<<<<<<< HEAD
=======
        Timer();
    }

    public void Timer()
    {
>>>>>>> parent of 47c6855 (bug fixes; all good except replay timer bug still NEEDS to be fixed;;)
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            gameTimer.fillAmount = timeLeft / gameTime;
        }
        else
        {
            // timesUpText.SetActive(true);
            Time.timeScale = 0;
<<<<<<< HEAD
            // PUT ENDSCREEN TRANSITION HERE (JUST MAKE IT VISIBLE AND GAME INVISIBLE)
=======
            hud.enabled = false;
            endMenu.enabled = true;
            

>>>>>>> parent of 47c6855 (bug fixes; all good except replay timer bug still NEEDS to be fixed;;)
        }
    }
}

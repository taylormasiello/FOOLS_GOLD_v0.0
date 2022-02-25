using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameTimer timer;
    EndMenu endMenu;

    void Awake()
    {
        endMenu = FindObjectOfType<EndMenu>();
        timer = FindObjectOfType<GameTimer>();
    }

    void Start()
    {

        endMenu.enabled = false;
    }

    void Update()
    {        
        if (timer.timeLeft == 0)
        {
            endMenu.enabled = true;
            // endScreen.ShowFinalScore(); PH for final score onto endScreen
        }

        EscApp();
    }

    public void OnReplyLevel()
    {
        SceneManager.LoadScene(0); 
    }

    public void QuitBtn()
    {
        Application.Quit();
    }

    void EscApp()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}

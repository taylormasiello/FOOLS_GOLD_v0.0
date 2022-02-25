using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
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

=======
    [SerializeField] Canvas endMenu;
    [SerializeField] Canvas hud;

    void Start()
    {
        endMenu.enabled = false;
        hud.enabled = true;
    }

    void Update()
    {   
>>>>>>> parent of 47c6855 (bug fixes; all good except replay timer bug still NEEDS to be fixed;;)
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

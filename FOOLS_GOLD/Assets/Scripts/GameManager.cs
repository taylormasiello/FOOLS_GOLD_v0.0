using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] EndMenu endMenu;
    [SerializeField] Canvas hud;
    [SerializeField] GameTimer gameTimer;

    void Awake()
    {
       endMenu = FindObjectOfType<EndMenu>();
       hud = GameObject.Find("HUD").GetComponent<Canvas>();
=======
    GameTimer timer;
    EndMenu endMenu;

    void Awake()
    {
        endMenu = FindObjectOfType<EndMenu>();
        timer = FindObjectOfType<GameTimer>();
>>>>>>> parent of 99afccf (functional game timer implemented)
    }

    void Start()
    {
<<<<<<< HEAD
        hud.gameObject.SetActive(true);
        endMenu.gameObject.SetActive(false);        
    }

    void Update()
    {
=======

        endMenu.enabled = false;
    }

    void Update()
    {        
        if (timer.timeLeft == 0)
        {
            endMenu.enabled = true;
            // endScreen.ShowFinalScore(); PH for final score onto endScreen
        }

>>>>>>> parent of 99afccf (functional game timer implemented)
        EscApp();
        EndScreen();
    }

    public void EndScreen()
    {
        if (gameTimer.gameOver)
        {
            hud.gameObject.SetActive(false);
            endMenu.gameObject.SetActive(true);
            //endMenu.ShowFinalScore();
        }
    }

    public void ReplyLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        gameTimer.StartTimer();

        // ***FIX REPLAY TIMER BUG** froze on replay 

        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex, UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }

    public void TitleMenu()
    {
        SceneManager.LoadSceneAsync(0);
        //SceneManager.UnloadSceneAsync(1, UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
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

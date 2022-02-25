using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] EndMenu endMenu;
    [SerializeField] Canvas hud;
    [SerializeField] GameTimer gameTimer;

    void Awake()
    {
       endMenu = FindObjectOfType<EndMenu>();
       hud = GameObject.Find("HUD").GetComponent<Canvas>();
    }

    void Start()
    {
        hud.gameObject.SetActive(true);
        endMenu.gameObject.SetActive(false);        
    }

    void Update()
    {
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

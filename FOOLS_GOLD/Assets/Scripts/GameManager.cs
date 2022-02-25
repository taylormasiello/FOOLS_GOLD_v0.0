using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Canvas endMenu;
    [SerializeField] Canvas hud;

    void Start()
    {
        endMenu.enabled = false;
        hud.enabled = true;
    }

    void Update()
    {   
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

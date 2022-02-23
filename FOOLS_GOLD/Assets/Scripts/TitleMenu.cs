using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    private void Update()
    {
        EscApp();
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene("Cave");

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Load next scene
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

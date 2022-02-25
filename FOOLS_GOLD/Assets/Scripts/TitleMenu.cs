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
        if (SceneManager.GetActiveScene().buildIndex - 1 >= 0)
        {
            SceneManager.LoadSceneAsync(1);
            //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex - 1, UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);            
        }
        else
        {
            SceneManager.LoadSceneAsync(1);
        }
        
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

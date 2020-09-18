using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript2 : MonoBehaviour
{
    public void StartGame()
    {

        SceneManager.LoadScene(3);
    }

    public void ExitGame()
    {

        Application.Quit();
    }

}
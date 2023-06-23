using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

     public void QuitGame()
    {
        Application.Quit();
    }
}

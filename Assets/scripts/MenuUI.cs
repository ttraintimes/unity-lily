using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public void enterBtn()
    {
        SceneManager.LoadScene("start");
    }
    public void restartBtn()
    {
        SceneManager.LoadScene("menu");
    }

    public void quitBtn()
    {
        Application.Quit();
    }

}

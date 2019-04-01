using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIscript : MonoBehaviour
{
    public void startButtonScene()
    {
        SceneManager.LoadScene("TankScene", LoadSceneMode.Single);
    }

    public void settingButtonScene()
    {
        SceneManager.LoadScene("SettingScene", LoadSceneMode.Single);
    }

    public void backStartButtonScene()
    {
        SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
    }

    public void loadStartScene()
    {
        SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
    }

    public void loadLevel1cene()
    {
        SceneManager.LoadScene("Sc_1", LoadSceneMode.Single);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int hitList;

    void Start()
    {

    }

    public void hitTaken()
    {
        hitList--;
        
        if (hitList <= 0)
        {
            int sceneID = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneID + 1, LoadSceneMode.Single);
        }
    }

    void Update()
    {
        
    }
}

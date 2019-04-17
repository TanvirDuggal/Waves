using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public int hitList;

    public Text timerText;
    private float secondsCount;
    private int minuteCount;
    private int hourCount;

    public GameObject instructionPanel;
   

    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = hourCount + "h:" + minuteCount + "m:" + (int)secondsCount + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
    }

    void Start()
    {
        
        StartCoroutine(Example());
        
    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(4);
#pragma warning disable CS0618 // Type or member is obsolete
        instructionPanel.active = false;
#pragma warning restore CS0618 // Type or member is obsolete
        
        print(Time.time);
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

    private void FixedUpdate()
    {
        UpdateTimerUI();
    }

    void Update()
    {
        
    }
}

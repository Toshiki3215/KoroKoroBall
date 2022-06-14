using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;   //using‚ð–Y‚ê‚È‚¢

public class GameManager : MonoBehaviour
{
    public Text textComponent;
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    private int coinCount;
    private void Start()
    {
        Screen.SetResolution(1920,1080,false);
        Application.targetFrameRate = 60;
        coinCount = 0;
    }
    public void AddCoinCount()
    {
        coinCount= coinCount+1;
        Debug.Log("CoinCount :" + coinCount);
        textComponent.text = "CoinCount : " + coinCount;
    }
}

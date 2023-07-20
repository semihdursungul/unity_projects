using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void LoadSummaryScreen()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadRulesScreen()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSuspects()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadDecision()
    {
        SceneManager.LoadScene(4);
    }
}

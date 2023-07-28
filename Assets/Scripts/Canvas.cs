using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour
{
    public GameObject LoseScene;
    public GameObject WinScene;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    public Text lose_text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void winButton()
    {
        WinScene.SetActive(true);
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);

    }

    public void loseButtont()
    {
        LoseScene.SetActive(true);
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);

    }

    public void Restart()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

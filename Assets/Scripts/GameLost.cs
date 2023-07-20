using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLost : MonoBehaviour
{
    public GameObject ContinueButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
        if (ContinueButton.activeInHierarchy == false)
            ContinueButton.SetActive(true);
    }
}

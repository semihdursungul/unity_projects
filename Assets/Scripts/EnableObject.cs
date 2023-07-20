using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObject : MonoBehaviour
{
    public GameObject ContinueButton;
    public GameObject LoseButton;
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

    public void loseText()
    {
        if (LoseButton.activeInHierarchy == false)
            LoseButton.SetActive(true);
    }
}

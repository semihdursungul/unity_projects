using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonText : MonoBehaviour
{
    public Text Textfield;

    public void SetText(string text)
    {
            Textfield.text = text;
    }

}

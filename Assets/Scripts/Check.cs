using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Check : MonoBehaviour
{
    public TMP_InputField email;
    public TMP_InputField password;

    public void Validation()
    {
        if (email.text == "binus@binus.edu" && password.text == "12345")
        {
            UnityEditor.EditorApplication.isPlaying = false; 
        }
    }
}

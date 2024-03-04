using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Check : MonoBehaviour
{
    public TMP_InputField email;
    public TMP_InputField password;
    public TMP_Text em;
    public TMP_Text pw;
    public void Validation()
    {
        if (email.text == "binus@binus.edu")
        {
            em.text = "";

        }
        else
        {
            em.text = "*email is invalid";
            em.color = Color.red;
        }

        if (password.text == "12345")
        {
            pw.text = "";
            //UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            pw.text = "*incorrect password";
            pw.color = Color.red;
        }

        if (email.text == "binus@binus.edu" && password.text == "12345")
        {
            UnityEditor.EditorApplication.isPlaying = false; 
        }
    }
}

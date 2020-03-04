using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Text.RegularExpressions;
using UnityEngine.EventSystems;

public class LOGIN : MonoBehaviour
{

    [SerializeField] Text log;

    public InputField inputusername;
    public InputField inputpassword;

    public Button LogIN;

    string LoginURL = "http://acmnitt.in/Test/login.php";
    

    public void calllogin()
    {
        StartCoroutine(LogInToDB());
    }

    IEnumerator LogInToDB()
    {
        WWWForm form = new WWWForm();

        form.AddField("usernamePost", inputusername.text);
        form.AddField("passwordPost", inputpassword.text);

        WWW www = new WWW(LoginURL, form);
        yield return www;

        string value1 = www.text;
        string value2 = inputpassword.text;

       

        //Debug.Log(www.text);

        if (value1 == value2)
        {
            DBManager.username = inputusername.text;
            SceneManager.LoadScene(1);
            Save.pwc = true;
        }
        else if(value1 == "no_user")
        {
            Save.nus = false;
            Save.pwc = true;
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(0);
            Save.nus = true;
            Save.pwc = false;
        }
    }
    public void VerifyInputs()
    {
        LogIN.interactable = (inputusername.text.Length >= 9 && inputpassword.text.Length >= 4);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(inputusername.isFocused)
            {
                inputpassword.Select();
            }

            if(inputpassword.isFocused)
            {
                inputusername.Select();
            }
        }

        if(Save.pwc == true && Save.nus == true)
        {
            log.text = "Login into Game";
        }

        else if(Save.nus == false && Save.pwc == true)
        {
            log.text = "Roll Number not registered";
        }

        else if(Save.pwc == false && Save.nus == true)
        {
            log.text = "Incorrect Password";
        }
    }
}

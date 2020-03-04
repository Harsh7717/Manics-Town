using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SendScore : MonoBehaviour
{
    public Text Player;
    public int escore;
    public int mscore;
    public int sscore;

    string LoginURL = "http://acmnitt.in/Test/save.php";

    private void Awake()
    {
        if(DBManager.username == null)
        {
            SceneManager.LoadScene(0);
        }

        Player.text = DBManager.username;
        escore = Save.EnemiesKilled;
        mscore = Save.Minutes;
        sscore = Save.Seconds;
    }

    public void CallSaveScore()
    {
        StartCoroutine(SaveData());
    }

    IEnumerator SaveData()
    {
        WWWForm form = new WWWForm();

        form.AddField("username", DBManager.username);
        form.AddField("enemy", Save.EnemiesKilled);
        form.AddField("minute", Save.Minutes);
        form.AddField("second", Save.Seconds);

        WWW www = new WWW(LoginURL, form);
        yield return www;

        //DBManager.LogOut();
        //SceneManager.LoadScene(0);
    }

}

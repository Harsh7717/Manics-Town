using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LeaderBoard : MonoBehaviour
{
    [SerializeField] Text PlayerEnemiesKilled;
    [SerializeField] Text PlayerMinutes;
    [SerializeField] Text PlayerSeconds;
    [SerializeField] Text NewHighScore;
    [SerializeField] Text HighScoreEnemiesKilled;
    [SerializeField] Text HighScoreMinutes;
    [SerializeField] Text HighScoreSeconds;

    public static int HSEK;
    public static int HSM;
    public static int HSS;

    private bool SetHighScore = false;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;

        HSEK = PlayerPrefs.GetInt("HSEnemiesKilled");
        HSM = PlayerPrefs.GetInt("HSMinutes");
        HSS = PlayerPrefs.GetInt("HSSeconds");

        PlayerEnemiesKilled.text = Save.EnemiesKilled + " ";
        PlayerMinutes.text = Save.GamePlayMinutes + " Minutes &";

        if(Save.GamePlaySeconds < 10)
        {
            PlayerSeconds.text = "0" + Save.GamePlaySeconds + " Seconds";
        }

        else
        {
            PlayerSeconds.text = Save.GamePlaySeconds + " Seconds";
        }

        if(Save.EnemiesKilled > HSEK)
        {
            NewHighScore.text = "NEW HIGHSCORE..!";

            SetHighScore = true;
            PlayerPrefs.SetInt("HSEnemiesKilled", Save.EnemiesKilled);
            PlayerPrefs.SetInt("HSMinutes", Save.GamePlayMinutes);
            PlayerPrefs.SetInt("HSSeconds", Save.GamePlaySeconds);
        }

        else if (Save.EnemiesKilled == HSEK)
        {
            if(Save.GamePlayMinutes < HSM)
            {
                NewHighScore.text = " NEW HIGHSCORE..!";
                SetHighScore = true;
                PlayerPrefs.SetInt("HSMinutes", Save.GamePlayMinutes);
                PlayerPrefs.SetInt("HSSeconds", Save.GamePlaySeconds);
            }

            else if (Save.GamePlaySeconds < HSS)
            {
                NewHighScore.text = " NEW HIGHSCORE..!";
                SetHighScore = true;
                PlayerPrefs.SetInt("HSSeconds", Save.GamePlaySeconds);
            }
        }

        else
        {
            NewHighScore.text = " ";
        }

        if(SetHighScore == true)
        {
            StartCoroutine(SetTheHighScore());
        }

        HighScoreEnemiesKilled.text = HSEK + " ";
        HighScoreMinutes.text = HSM + " Minutes &";

        if(HSS < 10)
        {
            HighScoreSeconds.text = "0" + HSS + " Seconds";
        }

        else
        {
            HighScoreSeconds.text = HSS + " Seconds";
        }
    }

    public void  BackToMenuButton ()
    {
        SceneManager.LoadScene(1);
        Save.PlayerHealth = 90;
    }

    IEnumerator SetTheHighScore ()
    {
        yield return new WaitForSeconds(0.5f);

        HSEK = PlayerPrefs.GetInt("HSEnemiesKilled");
        HSM = PlayerPrefs.GetInt("HSMinutes");
        HSS = PlayerPrefs.GetInt("HSSeconds");

        HighScoreEnemiesKilled.text = HSEK + " ";
        HighScoreMinutes.text = HSM + " Minutes &";

        if(HSS < 10)
        {
            HighScoreSeconds.text = "0" + HSS + " Seconds";
        }

        else
        {
            HighScoreSeconds.text = HSS + " Seconds";
        }
    }
}

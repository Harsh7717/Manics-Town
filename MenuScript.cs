using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public static bool LoadGame = false;

    [SerializeField] GameObject LoadButton;
    public int DataExits = 10;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Cursor.visible = true;
        LoadButton.gameObject.SetActive(false);
        DataExits = PlayerPrefs.GetInt("PlayersHealth", 0);
        MenuButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MenuButton()
    {
        if(Save.Replay == true)
        {
            if(Save.Saved == true)
            {
                if (DataExits > 0)
                {
                    LoadButton.gameObject.SetActive(true);
                }
            }
        }
    }

    public void LoadGameData()
    {
        LoadGame = true;
    }

    public void NewGameData()
    {
        LoadGame = false;

        Save.GamePlayMinutes = 0;
        Save.GamePlaySeconds = 0;
        Save.EnemiesKilled = 0;
        Save.Minutes = 0;
        Save.Seconds = 0;
        Save.Saved = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

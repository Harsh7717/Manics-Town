﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenu : MonoBehaviour
{
    [SerializeField] GameObject Controls;
    private bool ControlsOpen = false;

    [SerializeField] GameObject Options;
    private bool OptionsOpen = false;

    private bool SaveMessageActive = false;
    [SerializeField] GameObject SavedMessage;

    private bool MenuReturn = false;
    [SerializeField] GameObject BackToMenu;
    [SerializeField] GameObject MainMenuLoad;

    [SerializeField] GameObject GameExit;
    [SerializeField] GameObject SaveScore;

    // Start is called before the first frame update
    void Start()
    {
        SavedMessage.gameObject.SetActive(false);
        Controls.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        BackToMenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GameExit.gameObject.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            SaveScore.gameObject.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
        }


        if (Input.GetKeyDown(KeyCode.F2))
        {
            if(ControlsOpen == false)
            {
                Controls.gameObject.SetActive(true);
                ControlsOpen = true;
            }

            else if (ControlsOpen == true)
            {
                Controls.gameObject.SetActive(false);
                ControlsOpen = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            if (OptionsOpen == false)
            {
                Options.gameObject.SetActive(true);
                Cursor.visible = true;
                Time.timeScale = 0;
                OptionsOpen = true;
            }

            else if (OptionsOpen == true)
            {
                Options.gameObject.SetActive(false);
                Cursor.visible = false;
                Time.timeScale = 1;
                OptionsOpen = false;
            }
        }

        if(Save.SaveZone == true)
        {
            if(SaveMessageActive==false)
            {
                SavedMessage.gameObject.SetActive(true);
                SaveMessageActive = true;
            }
        }

        else if (Save.SaveZone == false)
        {
            if (SaveMessageActive == true)
            {
                SavedMessage.gameObject.SetActive(false);
                SaveMessageActive = false;
            }
        }

        if(Input.GetKeyDown(KeyCode.M))
        {
            if(MenuReturn == false)
            {
                BackToMenu.gameObject.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                MenuReturn = true;
            }
        }
    }

    public void ReturnToGame()
    {
        BackToMenu.gameObject.SetActive(false);
        GameExit.gameObject.SetActive(false);
        SaveScore.gameObject.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
        MenuReturn = false;
    }

    public void LoadMenu()
    {
        MainMenuLoad.gameObject.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

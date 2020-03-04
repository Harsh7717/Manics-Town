using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    [SerializeField] GameObject EnemyNumber1;
    [SerializeField] GameObject EnemyNumber2;
    [SerializeField] GameObject EnemyNumber3;
    [SerializeField] GameObject EnemyNumber4;
    [SerializeField] GameObject EnemyNumber5;
    [SerializeField] GameObject EnemyNumber6;
    [SerializeField] GameObject EnemyNumber7;
    [SerializeField] GameObject EnemyNumber8;
    [SerializeField] GameObject EnemyNumber9;
    [SerializeField] GameObject EnemyNumber10;
    [SerializeField] GameObject EnemyNumber11;
    [SerializeField] GameObject EnemyNumber12;
    [SerializeField] GameObject EnemyNumber13;
    [SerializeField] GameObject EnemyNumber14;
    [SerializeField] GameObject EnemyNumber15;
    [SerializeField] GameObject EnemyNumber16;
    [SerializeField] GameObject EnemyNumber17;
    [SerializeField] GameObject EnemyNumber18;

    [SerializeField] Transform SaveArea1;
    [SerializeField] Transform SaveArea2;
    [SerializeField] Transform SaveArea3;
    [SerializeField] Transform SaveArea4;

    [SerializeField] Transform PlayerCharacter;


    // Start is called before the first frame update
    void Start()
    {
        if (MenuScript.LoadGame == true)
        {
            Save.Diffiuculty = PlayerPrefs.GetFloat("DifficultyLevel");
            Save.Battries = PlayerPrefs.GetInt("BatteryNumber");
            Save.BatteryPower = PlayerPrefs.GetFloat("PowerBattery");
            Save.PlayerHealth = PlayerPrefs.GetInt("PlayersHealth");
            Save.Bullets = PlayerPrefs.GetInt("BulletLeft");

            if (PlayerPrefs.GetInt("Knife") == 1)
            {
                Save.HaveKnife = true;
            }

            if (PlayerPrefs.GetInt("Knife") == 0)
            {
                Save.HaveKnife = false;
            }

            if (PlayerPrefs.GetInt("Axe") == 1)
            {
                Save.HaveAxe = true;
            }

            if (PlayerPrefs.GetInt("Axe") == 0)
            {
                Save.HaveAxe = false;
            }

            if (PlayerPrefs.GetInt("Bat") == 1)
            {
                Save.HaveBat = true;
            }

            if (PlayerPrefs.GetInt("Bat") == 0)
            {
                Save.HaveBat = false;
            }

            if (PlayerPrefs.GetInt("Gun") == 1)
            {
                Save.HaveGun = true;
            }

            if (PlayerPrefs.GetInt("Gun") == 0)
            {
                Save.HaveGun = false;
            }

            if (PlayerPrefs.GetInt("Enemy1a") == 0)
            {
                EnemyNumber1.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy2a") == 0)
            {
                EnemyNumber2.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy3a") == 0)
            {
                EnemyNumber3.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy4a") == 0)
            {
                EnemyNumber4.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy5a") == 0)
            {
                EnemyNumber5.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy6a") == 0)
            {
                EnemyNumber6.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("Enemy7a") == 0)
            {
                EnemyNumber7.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy8a") == 0)
            {
                EnemyNumber8.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy9a") == 0)
            {
                EnemyNumber9.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy10a") == 0)
            {
                EnemyNumber10.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy11a") == 0)
            {
                EnemyNumber11.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy12a") == 0)
            {
                EnemyNumber12.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy13a") == 0)
            {
                EnemyNumber13.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy14a") == 0)
            {
                EnemyNumber14.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy15a") == 0)
            {
                EnemyNumber15.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy16a") == 0)
            {
                EnemyNumber16.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy17a") == 0)
            {
                EnemyNumber17.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Enemy18a") == 0)
            {
                EnemyNumber18.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Loacation") == 1)
            {
                PlayerCharacter.transform.position = SaveArea1.transform.position;
            }

            if (PlayerPrefs.GetInt("Loacation") == 2)
            {
                PlayerCharacter.transform.position = SaveArea2.transform.position;
            }

            if (PlayerPrefs.GetInt("Loacation") == 3)
            {
                PlayerCharacter.transform.position = SaveArea3.transform.position;
            }
            if (PlayerPrefs.GetInt("Loacation") == 4)
            {
                PlayerCharacter.transform.position = SaveArea4.transform.position;
            }

        }

        if (MenuScript.LoadGame == false)
        {
            Save.Diffiuculty = 1f;
            Save.WeaponID = 0;
            Save.Battries = 0;
            Save.BatteryPower = 1f;
            Save.PlayerHealth = 90;
            Save.HaveKnife = false;
            Save.HaveAxe = false;
            Save.HaveBat = false;
            Save.HaveGun = false;
            Save.Bullets = 25;
            Save.SaveZone = false;

            Save.Enemy1 = 1;
            Save.Enemy2 = 1;
            Save.Enemy3 = 1;
            Save.Enemy4 = 1;
            Save.Enemy5 = 1;
            Save.Enemy6 = 1;
            Save.Enemy7 = 1;
            Save.Enemy8 = 1;
            Save.Enemy9 = 1;
            Save.Enemy10 = 1;
            Save.Enemy11 = 1;
            Save.Enemy12 = 1;
            Save.Enemy13 = 1;
            Save.Enemy14 = 1;
            Save.Enemy15 = 1;
            Save.Enemy16 = 1;
            Save.Enemy17 = 1;
            Save.Enemy18 = 1;

            Save.SaveLocation = 0;
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveZoneScript : MonoBehaviour
{
    private float DifficultyLevel;
    private int BatteryNumber;
    private float PowerBattery;
    private int PlayersHealth;
    private int Knife;
    private int Axe;
    private int Bat;
    private int Gun;
    private int BulletLeft;

    private int Enemy1a;
    private int Enemy2a;
    private int Enemy3a;
    private int Enemy4a;
    private int Enemy5a;
    private int Enemy6a;
    private int Enemy7a;
    private int Enemy8a;
    private int Enemy9a;
    private int Enemy10a;
    private int Enemy11a;
    private int Enemy12a;
    private int Enemy13a;
    private int Enemy14a;
    private int Enemy15a;
    private int Enemy16a;
    private int Enemy17a;
    private int Enemy18a;

    [SerializeField] int SaveNumber = 0;

    private int Location;

    public int Batteries;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Save.SaveZone == true)
        {
            if(Save.HaveKnife == true)
            {
                Knife = 1;
            }
            if (Save.HaveKnife == false)
            {
                Knife = 0;
            }
            if (Save.HaveAxe == true)
            {
                Axe = 1;
            }
            if (Save.HaveAxe == false)
            {
                Axe = 0;
            }
            if (Save.HaveBat == true)
            {
                Bat = 1;
            }
            if (Save.HaveBat == false)
            {
                Bat = 0;
            }
            if (Save.HaveGun == true)
            {
                Gun = 1;
            }
            if (Save.HaveGun == false)
            {
                Gun = 0;
            }

           /* if (Input.GetKeyDown(KeyCode.L))
            {
                Save.Saved = true;
                PlayerPrefs.SetFloat("DifficultyLevel", Save.Diffiuculty);
                PlayerPrefs.SetInt("BatteryNumber", Save.Battries);
                PlayerPrefs.SetFloat("PowerBattery", Save.BatteryPower);
                PlayerPrefs.SetInt("PlayersHealth", Save.PlayerHealth);
                PlayerPrefs.SetInt("BulletLeft", Save.Bullets);

                PlayerPrefs.SetInt("Knife", Knife);
                PlayerPrefs.SetInt("Axe", Axe);
                PlayerPrefs.SetInt("Bat", Bat);
                PlayerPrefs.SetInt("Gun", Gun);

                if (Save.Enemy1 == 0)
                {
                    PlayerPrefs.SetInt("Enemy1a", Save.Enemy1);
                }

                if (Save.Enemy2 == 0)
                {
                    PlayerPrefs.SetInt("Enemy2a", Save.Enemy2);
                }

                if (Save.Enemy3 == 0)
                {
                    PlayerPrefs.SetInt("Enemy3a", Save.Enemy3);
                }

                if (Save.Enemy4 == 0)
                {
                    PlayerPrefs.SetInt("Enemy4a", Save.Enemy4);
                }

                if (Save.Enemy5 == 0)
                {
                    PlayerPrefs.SetInt("Enemy5a", Save.Enemy5);
                }

                if (Save.Enemy6 == 0)
                {
                    PlayerPrefs.SetInt("Enemy6a", Save.Enemy6);
                }

                if (Save.Enemy7 == 0)
                {
                    PlayerPrefs.SetInt("Enemy7a", Save.Enemy7);
                }
                if (Save.Enemy8 == 0)
                {
                    PlayerPrefs.SetInt("Enemy8a", Save.Enemy8);
                }
                if (Save.Enemy9 == 0)
                {
                    PlayerPrefs.SetInt("Enemy9a", Save.Enemy9);
                }
                if (Save.Enemy10 == 0)
                {
                    PlayerPrefs.SetInt("Enemy10a", Save.Enemy10);
                }
                if (Save.Enemy11 == 0)
                {
                    PlayerPrefs.SetInt("Enemy11a", Save.Enemy11);
                }
                if (Save.Enemy12 == 0)
                {
                    PlayerPrefs.SetInt("Enemy12a", Save.Enemy12);
                }
                if (Save.Enemy13 == 0)
                {
                    PlayerPrefs.SetInt("Enemy13a", Save.Enemy13);
                }
                if (Save.Enemy14 == 0)
                {
                    PlayerPrefs.SetInt("Enemy14a", Save.Enemy14);
                }
                if (Save.Enemy15 == 0)
                {
                    PlayerPrefs.SetInt("Enemy15a", Save.Enemy15);
                }
                if (Save.Enemy16 == 0)
                {
                    PlayerPrefs.SetInt("Enemy16a", Save.Enemy16);
                }
                if (Save.Enemy17 == 0)
                {
                    PlayerPrefs.SetInt("Enemy16a", Save.Enemy17);
                }
                if (Save.Enemy18 == 0)
                {
                    PlayerPrefs.SetInt("Enemy16a", Save.Enemy18);
                }

                Save.SaveLocation = SaveNumber;
                PlayerPrefs.SetInt("Location", Save.SaveLocation);
                PlayerPrefs.Save();

            }*/
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Save.SaveZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Save.SaveZone = false;
        }
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{ 
    public static float Diffiuculty = 1f;

    public static int WeaponID = 0;
    public static bool WeaponChange = false;

    public static bool flashLightOn = false;
    public static bool  NighVision = false;

    public static bool BatteryClick = false;

    public static int Battries = 0;

    public static float BatteryPower = 1f;

    public static bool CanPickup = false;

    public static int PlayerHealth = 90;
    public static bool DisplayHealth = true;

    public static bool HaveKnife = false;
    public static bool HaveBat = false;
    public static bool HaveAxe = false;
    public static bool HaveGun = false;

    public static int Bullets = 50;
    public static bool HaveBeenShot = false; 

    public static bool SaveZone = false;

    public static int Enemy1 = 1;
    public static int Enemy2 = 1;
    public static int Enemy3 = 1;
    public static int Enemy4 = 1;
    public static int Enemy5 = 1;
    public static int Enemy6 = 1;
    public static int Enemy7 = 1;
    public static int Enemy8 = 1;
    public static int Enemy9 = 1;
    public static int Enemy10 = 1;
    public static int Enemy11 = 1;
    public static int Enemy12 = 1;
    public static int Enemy13 = 1;
    public static int Enemy14 = 1;
    public static int Enemy15 = 1;
    public static int Enemy16 = 1;
    public static int Enemy17 = 1;
    public static int Enemy18 = 1;

    public static int SaveLocation = 0;

    public static bool HaveKey = false;

    public static bool ReadNote = false;

    public static bool Freeze = false;

    public static int Minutes = 0;
    public static int Seconds = 0;

    private float Duration = 0f;

    public static int GamePlayMinutes = 0;
    public static int GamePlaySeconds = 0;
    public static int EnemiesKilled = 0;

    public static bool Replay = false;
    public static bool Saved = false;

    public static bool pwc = true;
    public static bool nus = true;

    public static bool CanShoot = false;

    private void Start()
    {
        PlayerHealth = 90;
        Bullets = 25;
    }

    private void Update()
    {
        Duration = Duration + 1 * Time.deltaTime;

        if (Duration > 1f)
        {
            Seconds++;
            Duration = 0f;
        }

        if (Seconds == 60)
        {
            Minutes++;
            Seconds = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    [SerializeField] GameObject ChaseMusic;
    [SerializeField] int EnemyNumber;

    public static bool enemydead = false;

    // Start is called before the first frame update
    void Start()
    {
        ChaseMusic.gameObject.SetActive(false);

        if(EnemyNumber == 1)
        {
            Save.Enemy1 = 0;
            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }

        if (EnemyNumber == 2)
        {
            Save.Enemy2 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }

        if (EnemyNumber == 3)
        {
            Save.Enemy3 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }

        if (EnemyNumber == 4)
        {
            Save.Enemy4 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }

        if (EnemyNumber == 5)
        {
            Save.Enemy5 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }

        if (EnemyNumber == 6)
        {
            Save.Enemy6 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
            enemydead = true;
        }
        if (EnemyNumber == 7)
        {
            Save.Enemy7 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }
        if (EnemyNumber == 8)
        {
            Save.Enemy8 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }
        if (EnemyNumber == 9)
        {
            Save.Enemy9 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }
        if (EnemyNumber == 10)
        {
            Save.Enemy10 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }
        if (EnemyNumber == 11)
        {
            Save.Enemy11 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }
        if (EnemyNumber == 12)
        {
            Save.Enemy12 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }
        if (EnemyNumber == 16)
        {
            Save.Enemy16 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }
        if (EnemyNumber == 13)
        {
            Save.Enemy13 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }
        if (EnemyNumber == 14)
        {
            Save.Enemy14 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }
        if (EnemyNumber == 15)
        {
            Save.Enemy15 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }
        if (EnemyNumber == 17)
        {
            Save.Enemy17 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }
        if (EnemyNumber == 18)
        {
            Save.Enemy18 = 0;

            Save.EnemiesKilled++;
            Save.GamePlayMinutes = Save.Minutes;
            Save.GamePlaySeconds = Save.Seconds;
        }
    }
}

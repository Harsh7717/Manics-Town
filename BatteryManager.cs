using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryManager : MonoBehaviour
{
    [SerializeField] GameObject BatteryImage1;
    [SerializeField] GameObject BatteryImage2;
    [SerializeField] GameObject BatteryImage3;
    [SerializeField] GameObject BatteryImage4;

    [SerializeField] GameObject BatteryButton1;
    [SerializeField] GameObject BatteryButton2;
    [SerializeField] GameObject BatteryButton3;
    [SerializeField] GameObject BatteryButton4;
    // Start is called before the first frame update
    void Start()
    {
        Save.BatteryClick = true;
    }

    // Update is called once per frame
    void Update()
    {
        CheckBatteries();
    }

    void CheckBatteries()
    {
        if(Save.BatteryClick == true)
        {
            if(Save.Battries == 0)
            {
                BatteryImage1.gameObject.SetActive(false);
                BatteryImage2.gameObject.SetActive(false);
                BatteryImage3.gameObject.SetActive(false);
                BatteryImage4.gameObject.SetActive(false);

                BatteryButton1.gameObject.SetActive(false);
                BatteryButton2.gameObject.SetActive(false);
                BatteryButton3.gameObject.SetActive(false);
                BatteryButton4.gameObject.SetActive(false);
            }

            if (Save.Battries == 1)
            {
                BatteryImage1.gameObject.SetActive(true);
                BatteryImage2.gameObject.SetActive(false);
                BatteryImage3.gameObject.SetActive(false);
                BatteryImage4.gameObject.SetActive(false);

                BatteryButton1.gameObject.SetActive(true);
                BatteryButton2.gameObject.SetActive(false);
                BatteryButton3.gameObject.SetActive(false);
                BatteryButton4.gameObject.SetActive(false);
            }

            if (Save.Battries == 2)
            {
                BatteryImage1.gameObject.SetActive(true);
                BatteryImage2.gameObject.SetActive(true);
                BatteryImage3.gameObject.SetActive(false);
                BatteryImage4.gameObject.SetActive(false);

                BatteryButton1.gameObject.SetActive(true);
                BatteryButton2.gameObject.SetActive(true);
                BatteryButton3.gameObject.SetActive(false);
                BatteryButton4.gameObject.SetActive(false);
            }

            if (Save.Battries == 3)
            {
                BatteryImage1.gameObject.SetActive(true);
                BatteryImage2.gameObject.SetActive(true);
                BatteryImage3.gameObject.SetActive(true);
                BatteryImage4.gameObject.SetActive(false);

                BatteryButton1.gameObject.SetActive(true);
                BatteryButton2.gameObject.SetActive(true);
                BatteryButton3.gameObject.SetActive(true);
                BatteryButton4.gameObject.SetActive(false);
            }

            if (Save.Battries == 4)
            {
                BatteryImage1.gameObject.SetActive(true);
                BatteryImage2.gameObject.SetActive(true);
                BatteryImage3.gameObject.SetActive(true);
                BatteryImage4.gameObject.SetActive(true);

                BatteryButton1.gameObject.SetActive(true);
                BatteryButton2.gameObject.SetActive(true);
                BatteryButton3.gameObject.SetActive(true);
                BatteryButton4.gameObject.SetActive(true);
            }
        }
    }
}

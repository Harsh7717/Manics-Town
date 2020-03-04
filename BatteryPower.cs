using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryPower : MonoBehaviour
{
    [SerializeField] Image BatteryUI;
    [SerializeField] float DrainTime = 15.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Refill()
    {
        BatteryUI.fillAmount = 1;
        Save.Battries -= 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Save.flashLightOn == true)
        {
            BatteryUI.fillAmount -= 1.0f / DrainTime * Time.deltaTime;
            Save.BatteryPower = BatteryUI.fillAmount;

            if(Save.BatteryPower == 0)
            {
                Save.flashLightOn = false;
            }
        }

        if(Save.NighVision == true)
        {
            BatteryUI.fillAmount -= 1.0f / DrainTime * Time.deltaTime;
            Save.BatteryPower = BatteryUI.fillAmount;

            if (Save.BatteryPower == 0)
            {
                Save.NighVision = false;
            }
        }
       
    }
}

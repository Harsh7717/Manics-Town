using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    [SerializeField] GameObject flashLight;
    [SerializeField] GameObject enemyLight;

    private bool LightOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Save.flashLightOn == false)
        {
            flashLight.gameObject.SetActive(false);
            enemyLight.gameObject.SetActive(false);
            Save.flashLightOn = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if(Save.flashLightOn == false)
            {
                flashLight.gameObject.SetActive(true);
                enemyLight.gameObject.SetActive(true);

                Save.flashLightOn = true;
            }

            else if (Save.flashLightOn == true)
            {
                flashLight.gameObject.SetActive(false);
                enemyLight.gameObject.SetActive(false);
                Save.flashLightOn = false;
            }
        }
    }
}

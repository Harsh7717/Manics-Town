using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    [SerializeField] GameObject Pickup;
    [SerializeField] GameObject PickupMessage;

    [Tooltip("1 = apple, 2 = battery, 3 = knife, 4 = bat, 5 = axe, 6 = gun, 7 = Note")]
    [SerializeField] int PickupType;

    private bool PickupActive = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            PickupActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PickupActive = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PickupActive == true)
        {
            //if(Save.CanPickup == true)
            //{
                if(Input.GetKeyDown(KeyCode.E))
                {
                    PickupMessage.gameObject.SetActive(false);
                    PickupCheck();
                }
            //}
        }

    }
    void PickupCheck()
    {
        if (PickupType == 1)
        {
            Save.PlayerHealth += 10;
            Save.Bullets += 5;

            if(Save.PlayerHealth > 100)
            {
                Save.PlayerHealth = 100;
            }
            Save.DisplayHealth = true;
            Destroy(Pickup, 0.2f);
        }

        if (PickupType == 2)
        {
            if (Save.Battries < 4)
            {
                Save.Battries += 1;
                Destroy(Pickup, 0.2f);
            }
        }

            if (PickupType == 3)
        {
            Save.HaveKnife = true;
            Destroy(Pickup, 0.2f);
        }

        if (PickupType == 4)
        {
            Save.HaveBat = true;
            Destroy(Pickup, 0.2f);
        }

        if (PickupType == 5)
        {
            Save.HaveAxe = true;
            Destroy(Pickup, 0.2f);
        }

        if (PickupType == 6)
        {
            Save.HaveGun = true;
            Destroy(Pickup, 0.2f);
        }

        if (PickupType == 7)
        {
            Save.ReadNote = true;
        }

    }

}

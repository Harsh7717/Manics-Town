using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{

    //Visible in inspector;
    [SerializeField] GameObject InventoryMenu;
    [SerializeField] GameObject KnifeImage;
    [SerializeField] GameObject KnifeButton;
    [SerializeField] GameObject BatImage;
    [SerializeField] GameObject BatButton;
    [SerializeField] GameObject AxeImage;
    [SerializeField] GameObject AxeButton;
    [SerializeField] GameObject GunImage;
    [SerializeField] GameObject GunButton;
    [SerializeField] GameObject KnifeBlank;
    [SerializeField] GameObject BatBlank;
    [SerializeField] GameObject AxeBlank;
    [SerializeField] GameObject GunBlank;


    //Invisible in inspector;
    private bool InventoryActive = false;
    private bool ExitInventory = true;
 
    void Start()
    {
        InventoryMenu.gameObject.SetActive(false);
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            if(InventoryActive == false)
            {
                ExitInventory = false;
                StartCoroutine(InventoryOpen());
            }
            else if (InventoryActive == true)
            {
                if(ExitInventory == true)
                {
                    Time.timeScale = 1f;
                    InventoryMenu.gameObject.SetActive(false);
                    InventoryActive = false;
                    Cursor.visible = false;
                }
            }
        }
    }


    public void ChooseKnife()
    {
        Save.WeaponID = 1;
        Save.WeaponChange = true;
    }
    public void ChooseBat()
    {
        Save.WeaponID = 2;
        Save.WeaponChange = true;
    }
    public void ChooseAxe()
    {
        Save.WeaponID = 3;
        Save.WeaponChange = true;
    }
    public void ChooseGun()
    {
        Save.WeaponID = 4;
        Save.WeaponChange = true;
    }

    IEnumerator InventoryOpen()
    {
        InventoryMenu.gameObject.SetActive(true);
        InventoryCheck();
        InventoryActive = true;
        Cursor.visible = true;

        yield return new WaitForSeconds(1f);
        Time.timeScale = 0f;
        ExitInventory = true;
    }

    void InventoryCheck()
    {
        if(Save.HaveKnife == true)
        {
            KnifeBlank.gameObject.SetActive(false);
            KnifeImage.gameObject.SetActive(true);
            KnifeButton.gameObject.SetActive(true);
        }

        if (Save.HaveKnife == false)
        {
            KnifeBlank.gameObject.SetActive(true);
            KnifeImage.gameObject.SetActive(false);
            KnifeButton.gameObject.SetActive(false);
        }

        if (Save.HaveBat == true)
        {
            BatBlank.gameObject.SetActive(false);
            BatImage.gameObject.SetActive(true);
            BatButton.gameObject.SetActive(true);
        }

        if (Save.HaveBat == false)
        {
            BatBlank.gameObject.SetActive(true);
            BatImage.gameObject.SetActive(false);
            BatButton.gameObject.SetActive(false);
        }

        if (Save.HaveAxe == true)
        {
            AxeBlank.gameObject.SetActive(false);
            AxeImage.gameObject.SetActive(true);
            AxeButton.gameObject.SetActive(true);
        }

        if (Save.HaveAxe == false)
        {
            AxeBlank.gameObject.SetActive(true);
            AxeImage.gameObject.SetActive(false);
            AxeButton.gameObject.SetActive(false);
        }

        if (Save.HaveGun == true)
        {
            GunBlank.gameObject.SetActive(false);
            GunImage.gameObject.SetActive(true);
            GunButton.gameObject.SetActive(true);
        }

        if (Save.HaveGun == false)
        {
            GunBlank.gameObject.SetActive(true);
            GunImage.gameObject.SetActive(false);
            GunButton.gameObject.SetActive(false);
        }
    }
}

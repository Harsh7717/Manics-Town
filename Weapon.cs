using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private int CurrentWeapon;
    [SerializeField] GameObject knife;
    [SerializeField] GameObject Baseball;
    [SerializeField] GameObject Axe;
    [SerializeField] GameObject Gun;
    [SerializeField] float WaitTime = 1.0f;

    private Animator anim;
    private bool WeaponVisible = false;

    private bool Attack = true;

    // Start is called before the first frame update
    void Start()
    {
        Save.WeaponChange = true;
        CurrentWeapon = Save.WeaponID;

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Save.WeaponChange == true)
        {
            AssignWeapon();
        }

        if(Input.GetKeyDown(KeyCode.I))
        {
            if(WeaponVisible == true)
            {
                if(CurrentWeapon > 0 && CurrentWeapon < 4)
                {
                    WeaponVisible = false;
                    anim.SetBool("Ready", false);
                }

                else if (CurrentWeapon == 4)
                {
                    WeaponVisible = false;
                    anim.SetBool("GunAnim", false);
                }
                
            }
        }


        if(CurrentWeapon > 0 && CurrentWeapon < 4)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                if(WeaponVisible == false)
                {
                    WeaponVisible = true;
                    anim.SetBool("Ready", true);
                }

                else if (WeaponVisible == true)
                {
                    WeaponVisible = false;
                    anim.SetBool("Ready", false);
                }
            }

            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                if(Attack == true)
                {
                    if(CurrentWeapon == 1)
                    {
                        anim.SetInteger("WeaponStrike", 1);
                        Attack = false;
                        StartCoroutine(WeaponWait());
                    }

                    if (CurrentWeapon == 2)
                    {
                        anim.SetInteger("WeaponStrike", 2);
                        Attack = false;
                        StartCoroutine(WeaponWait());
                    }

                    if (CurrentWeapon == 3)
                    {
                        anim.SetInteger("WeaponStrike", 3);
                        Attack = false;
                        StartCoroutine(WeaponWait());
                    }

                }
            }
        }

        if(CurrentWeapon == 4)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                if (WeaponVisible == false)
                {
                    WeaponVisible = true;
                    anim.SetBool("GunAnim", true);
                }

                else if (WeaponVisible == true)
                {
                    WeaponVisible = false;
                    anim.SetBool("GunAnim", false);
                }
            }

            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                if(Attack == true)
                {
                    if(CurrentWeapon == 4)
                    {
                        anim.SetInteger("WeaponStrike", 4);
                        Attack = false;
                        StartCoroutine(WeaponWait());
                    }
                }
            }
        }
    }

    void AssignWeapon()
    {
        Save.WeaponChange = false;
        CurrentWeapon = Save.WeaponID;

        if (CurrentWeapon == 0)
        {
            knife.gameObject.SetActive(false);
            Baseball.gameObject.SetActive(false);
            Axe.gameObject.SetActive(false);
            Gun.gameObject.SetActive(false);
        }

        if (CurrentWeapon == 1)
        {
            knife.gameObject.SetActive(true);
            Baseball.gameObject.SetActive(false);
            Axe.gameObject.SetActive(false);
            Gun.gameObject.SetActive(false);
            WaitTime = 1.0f;
        }

        if (CurrentWeapon == 2)
        {
            knife.gameObject.SetActive(false);
            Baseball.gameObject.SetActive(true);
            Axe.gameObject.SetActive(false);
            Gun.gameObject.SetActive(false);
            WaitTime = 1f;
        }

        if (CurrentWeapon == 3)
        {
            knife.gameObject.SetActive(false);
            Baseball.gameObject.SetActive(false);
            Axe.gameObject.SetActive(true);
            Gun.gameObject.SetActive(false);
            WaitTime = 1.6f;
        }

        if (CurrentWeapon == 4)
        {
            knife.gameObject.SetActive(false);
            Baseball.gameObject.SetActive(false);
            Axe.gameObject.SetActive(false);
            Gun.gameObject.SetActive(true);
            WaitTime = 0.5f;
        }
    }

    IEnumerator WeaponWait()
    {
        yield return new WaitForSeconds(0.2f);
        anim.SetInteger("WeaponStrike", 0);
        yield return new WaitForSeconds(WaitTime);

        Attack = true;
        
    }
}

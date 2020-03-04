using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponDamage : MonoBehaviour
{
    [SerializeField] GameObject HurtUI;
    [SerializeField] int WeaponDamage = 2;

    AudioSource HitSound;

    private bool HitActive = false;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        HurtUI.gameObject.SetActive(false);
        HitSound = GetComponent<AudioSource>();
        anim = GetComponentInParent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(HitActive == false)
            {
                if(anim.GetBool("Damagging")==true)
                {
                    HitActive = true;
                    HurtUI.gameObject.SetActive(true);
                    HitSound.Play(0);
                    Save.PlayerHealth -= WeaponDamage;
                    Save.DisplayHealth = true;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (HitActive == true)
            {
                HitActive = false;
            }
        }
    }
}

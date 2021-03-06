﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int EnemiesHealth = 100;
    [SerializeField] int BatDamage = 10;
    [SerializeField] int KnifeDamage = 30;
    [SerializeField] int AxeDamage = 60;
    [SerializeField] int GunDamage = 85;
    private Animator anim;
    private bool PlayerHitMe = false;

    AudioSource HitEnemy;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInParent<Animator>();
        HitEnemy = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemiesHealth <=0)
        {
            anim.SetBool("Die", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PBat"))
        {
            if(PlayerHitMe == false)
            {
                PlayerHitMe = true;
                EnemiesHealth -= BatDamage;
                anim.SetTrigger("React");
                HitEnemy.Play(0);
            }
        }

        if (other.gameObject.CompareTag("PKnife"))
        {
            if (PlayerHitMe == false)
            {
                PlayerHitMe = true;
                EnemiesHealth -= KnifeDamage;
                anim.SetTrigger("React");
                HitEnemy.Play(0);
            }
        }

        if (other.gameObject.CompareTag("PAxe"))
        {
            if (PlayerHitMe == false)
            {
                PlayerHitMe = true;
                EnemiesHealth -= AxeDamage;
                anim.SetTrigger("React");
                HitEnemy.Play(0);
            }
        }
        if (other.gameObject.CompareTag("PGun"))
        {
            if (PlayerHitMe == false)
            {
                PlayerHitMe = true;
                EnemiesHealth -= GunDamage;
                anim.SetTrigger("React");
                HitEnemy.Play(0);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PBat"))
        {
            if (PlayerHitMe == true)
            {
                PlayerHitMe = false;
            }
        }
        if (other.gameObject.CompareTag("PKnife"))
        {
            if (PlayerHitMe == true)
            {
                PlayerHitMe = false;
            }
        }
        if (other.gameObject.CompareTag("PAxe"))
        {
            if (PlayerHitMe == true)
            {
                PlayerHitMe = false;
            }
        }
        if (other.gameObject.CompareTag("PGun"))
        {
            if (PlayerHitMe == true)
            {
                PlayerHitMe = false;
            }
        }
    }
}

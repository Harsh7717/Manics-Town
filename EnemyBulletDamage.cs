using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDamage : MonoBehaviour
{
    [SerializeField] int WeaponDamage = 60;
    AudioSource HitSound;

    private bool HitActive = false;

    // Start is called before the first frame update
    void Start()
    {
        HitSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (HitActive == false)
            {
                    HitActive = true;
                    HitSound.Play(0);
                    Save.PlayerHealth -= WeaponDamage;
                    Save.DisplayHealth = true;
                    Save.HaveBeenShot = true;
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

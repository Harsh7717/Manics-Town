using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] float ChaseSpeed = 10.5f;

    private float NewChaseSpeed = 0.0f;

    [SerializeField] GameObject Petrol;
    [SerializeField] float AttackDistance = 2.7f;
    [SerializeField] GameObject ChaseMusic;
    [SerializeField] float MaxDistance = 20f;

    [SerializeField] bool IHaveAxe = false;
    [SerializeField] bool IHaveBat = false;
    [SerializeField] bool IHaveKnife = false;
    [SerializeField] bool IHaveGun = false;

    private float DistanceToPlayer;

    private bool RunToPlayer = false;
    private Animator anim;
    private NavMeshAgent nav;
    private bool MusicOn = false;

    private bool run = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
        Petrol.gameObject.SetActive(true);
        ChaseMusic.gameObject.SetActive(false);
        MusicOn = false;
        NewChaseSpeed = ChaseSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("TriggerPlayer"))
        {
            RunToPlayer = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(RunToPlayer == true)
        {
            DistanceToPlayer = Vector3.Distance(Player.transform.position, transform.position);
            if(DistanceToPlayer < MaxDistance)
            {
                if(MusicOn == false)
                {
                    ChaseMusic.gameObject.SetActive(true);
                    MusicOn = true;
                }
            }

            else if(DistanceToPlayer > MaxDistance)
            {
                if(MusicOn == true)
                {
                    ChaseMusic.gameObject.SetActive(false);
                    MusicOn = false;
                }
            }

            Petrol.gameObject.SetActive(false);

         
            if(DistanceToPlayer < AttackDistance)
            {
                run = false;
                if(IHaveBat == true)
                {
                    anim.SetBool("BatAttacks", true);
                    anim.SetBool("Damagging", true);
                    NewChaseSpeed = 0.0f;
                    nav.angularSpeed = 650000000;
                }
                if (IHaveAxe == true)
                {
                    anim.SetBool("Alert", false);
                    anim.SetBool("AxeAttacks", true);
                    anim.SetBool("Damagging", true);
                    NewChaseSpeed = 0.0f;
                    nav.angularSpeed = 650000000;
                }
                if (IHaveKnife == true)
                {
                    anim.SetBool("KnifeAttacks", true);
                    anim.SetBool("Damagging", true);
                    NewChaseSpeed = 0.0f;
                    nav.angularSpeed = 650000000;
                }
                if (IHaveGun == true)
                {
                    anim.SetBool("GunAttacks", true);
                    anim.SetBool("Damagging", true);
                    Save.CanShoot = true;
                    NewChaseSpeed = 0.0f;
                    nav.angularSpeed = 650000000;
                }
            }

            else if(DistanceToPlayer > AttackDistance)
            { 
                run = true;
                if(IHaveBat == true)
                {
                    anim.SetBool("Alert", true);
                    anim.SetBool("BatAttacks", false);
                    anim.SetBool("Damagging", false);
                    NewChaseSpeed = ChaseSpeed * Save.Diffiuculty;
                    nav.angularSpeed = 25000;
                }
                if (IHaveAxe == true)
                {
                    anim.SetBool("Alert", true);
                    anim.SetBool("AxeAttacks", false);
                    anim.SetBool("Damagging", false);
                    NewChaseSpeed = ChaseSpeed * Save.Diffiuculty;
                    nav.angularSpeed = 25000;
                }
                if (IHaveKnife == true)
                {
                    anim.SetBool("Alert", true);
                    anim.SetBool("KnifeAttacks", false);
                    anim.SetBool("Damagging", false);
                    NewChaseSpeed = ChaseSpeed * Save.Diffiuculty;
                    nav.angularSpeed = 25000;
                }
                if (IHaveGun == true)
                {
                    anim.SetBool("Alert", true);
                    anim.SetBool("GunAttacks", false);
                    anim.SetBool("Damagging", false);
                    Save.CanShoot = false;
                    NewChaseSpeed = ChaseSpeed * Save.Diffiuculty;
                    nav.angularSpeed = 25000;
                }
            }

            if (run == true)
            {
                nav.speed = NewChaseSpeed;
                nav.SetDestination(Player.transform.position);
            }
        }
    }
}

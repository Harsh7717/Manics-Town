using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    // visible in inspector

    [SerializeField] Transform Target1;
    [SerializeField] Transform Target2;
    [SerializeField] Transform Target3;
    [SerializeField] Transform Target4;
    [SerializeField] Transform Target5;
    [SerializeField] Transform Target6;
    [SerializeField] Transform Target7;
    [SerializeField] Transform Target8;
    [SerializeField] Transform Target9;
    [SerializeField] Transform Target10;


    [SerializeField] int WaitTime = 0;

    [SerializeField] int Enemynum;

    [SerializeField] string TargetName;
    [SerializeField] string TargetDescriptor;

    //invisible in inspector

    private int CurrentTarget = 1;

    private Transform TargetPosition;

    private Animator anim;

    private int LastTarget = 1;

    private bool contact = false;


    // Start is called before the first frame update
    void Start()
    {   
        TargetPosition = Target1;
        MoveToTarget();

        anim = GetComponentInParent<Animator>();
        LastTarget = CurrentTarget;

        TargetDescriptor = Enemynum + "Target Cube1";
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("EnemyTarget"))
        {
            TargetName = other.GetComponent<Collider>().name;

            if(TargetName == TargetDescriptor)
            {
                if (contact == false)
                {
                    contact = true;
                    CurrentTarget = Random.Range(1, 11);

                    if (CurrentTarget == LastTarget)
                    {
                        TryAgain();
                    }
                    else
                    {
                        StartCoroutine(Waiting());
                    }
                }
            }
        }
    }

    void TryAgain()
    {
        if(LastTarget == 1)
        {
            CurrentTarget = LastTarget + 1;
        }

        else if(LastTarget>1)
        {
            CurrentTarget = LastTarget - 1;
        }

        StartCoroutine(Waiting());
    }

    void MoveToTarget()
    {
        if(CurrentTarget==1)
        {
            TargetPosition = Target1;
            TargetDescriptor = Enemynum + "Target Cube1";
        }

        if (CurrentTarget == 2)
        {
            TargetPosition = Target2;
            TargetDescriptor = Enemynum + "Target Cube2";
        }

        if (CurrentTarget == 3)
        {
            TargetPosition = Target3;
            TargetDescriptor = Enemynum + "Target Cube3";
        }

        if (CurrentTarget == 4)
        {
            TargetPosition = Target4;
            TargetDescriptor = Enemynum + "Target Cube4";
        }

        if (CurrentTarget == 5)
        {
            TargetPosition = Target5;
            TargetDescriptor = Enemynum + "Target Cube5";
        }

        if (CurrentTarget == 6)
        {
            TargetPosition = Target6;
            TargetDescriptor = Enemynum + "Target Cube6";
        }

        if (CurrentTarget == 7)
        {
            TargetPosition = Target7;
            TargetDescriptor = Enemynum + "Target Cube7";
        }

        if (CurrentTarget == 8)
        {
            TargetPosition = Target8;
            TargetDescriptor = Enemynum + "Target Cube8";
        }

        if (CurrentTarget == 9)
        {
            TargetPosition = Target9;
            TargetDescriptor = Enemynum + "Target Cube9";
        }

        if (CurrentTarget == 10)
        {
            TargetPosition = Target10;
            TargetDescriptor = Enemynum + "Target Cube10";
        }

        GetComponentInParent<NavMeshAgent>().destination = TargetPosition.position;

        LastTarget = CurrentTarget;

        //contact = false;
    }

    IEnumerator Waiting()
    {
        anim.SetInteger("State", 1);
        yield return new WaitForSeconds(WaitTime);
        anim.SetInteger("State", 0);
        contact = false;
        MoveToTarget();
    }
}

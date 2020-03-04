using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHide : MonoBehaviour
{

    [SerializeField] GameObject enemy;
    [SerializeField] GameObject collid;

    // Start is called before the first frame update
    void Start()
    {
        enemy.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("TriggerPlayer"))
        {
            enemy.gameObject.SetActive(true);
            collid.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

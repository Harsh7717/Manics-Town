using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotSound : MonoBehaviour
{
    [SerializeField] GameObject SoundSource;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SoundSource.gameObject.SetActive(true);
            Destroy(gameObject, 7);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [SerializeField] float distance = 2.0f;
    [SerializeField] LayerMask IgnoreLayers;
    [SerializeField] GameObject PickupMessage;

    RaycastHit hit;

    private Transform Selected;
    private Transform Selection;


    void Update()
    {
        if(Selection != null)
        {
            PickupMessage.gameObject.SetActive(false);
            Selection = null;
        }

        if (Selected == null)
        {
            PickupMessage.gameObject.SetActive(false);
            Save.CanPickup = false;
        }

        if(Physics.Raycast(transform.position, transform.forward, out hit, distance, ~IgnoreLayers))
        {
            Selected = hit.transform;
            if(hit.transform.tag == "Pickups")
            {
                PickupMessage.gameObject.SetActive(true);
                Save.CanPickup = true;
            }
            Selection = Selected;
        }
    }
}

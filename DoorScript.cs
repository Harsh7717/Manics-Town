using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    [SerializeField] GameObject DoorMessage;
    [SerializeField] bool Locked;
    private Animator Anim;

    private bool CanOpen; 
    
    [SerializeField] Text MessageText;
    // Start is called before the first frame update
    void Start()
    {
        DoorMessage.gameObject.SetActive(false);
        Anim = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Locked == false)
        {
            if (CanOpen == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Anim.SetTrigger("Open");
                }
            }
        }

        if(Locked == true)
        {
            if(Save.HaveKey == true)
            {
                Locked = false;

                MessageText.text = "Unlocked - Press E to Open";
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TriggerPlayer"))
        {
            DoorMessage.gameObject.SetActive(true);
            CanOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("TriggerPlayer"))
        {
            DoorMessage.gameObject.SetActive(false);
            CanOpen = false;
        }
    }
}

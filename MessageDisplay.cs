using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageDisplay : MonoBehaviour
{
    [SerializeField] GameObject MessagePanal;
    [SerializeField] GameObject TriggerBox;
    // Start is called before the first frame update
    void Start()
    {
        MessagePanal.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            MessagePanal.gameObject.SetActive(true);
            Cursor.visible = true;

            Time.timeScale = 0;
        }
    }

    public void ExitMessage()
    {
        MessagePanal.gameObject.SetActive(false);
        Cursor.visible = false;

        Time.timeScale = 1;
        Destroy(TriggerBox, 0.5f);
    }
}

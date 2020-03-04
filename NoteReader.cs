using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteReader : MonoBehaviour
{
    [SerializeField] GameObject Note;
    // Start is called before the first frame update
    void Start()
    {
        Note.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Save.ReadNote == true)
        {
            Cursor.visible = true;
            Note.gameObject.SetActive(true);
        }
    }

    public void CloseNote()
    {
        Save.ReadNote = false;
        Note.gameObject.SetActive(false);
        Cursor.visible = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBullets : MonoBehaviour
{
    [SerializeField] Text PHText;
    // Start is called before the first frame update
    void Start()
    {
        PHText.text = Save.Bullets + " ";
    }

    // Update is called once per frame
    void Update()
    {
            PHText.text = Save.Bullets + " ";
    }
}

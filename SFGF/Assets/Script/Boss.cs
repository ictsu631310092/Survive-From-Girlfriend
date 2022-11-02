using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (itemmanager.haveChocolate == true && itemmanager.haveDoll == true)
            {
                Cursor.visible = true;
                manumanager.OpenwinnerUI = true;
            }
            else
            {
                Cursor.visible = true;
                manumanager.OpenGameoverUI = true;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

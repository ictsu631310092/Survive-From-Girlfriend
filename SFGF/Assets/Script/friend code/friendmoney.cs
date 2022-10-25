using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class friendmoney : MonoBehaviour
{
    public static int _friendmoney = 50;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_friendmoney == 0)
        {
            Destroy(GetComponent<Collider>().gameObject);
        }
    }
}

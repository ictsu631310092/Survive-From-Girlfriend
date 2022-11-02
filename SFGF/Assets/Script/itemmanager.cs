using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemmanager : MonoBehaviour
{
    public static int moneyhave = 0;
    public GameObject chocolate;
    public static bool haveChocolate = false;
    public GameObject doll;
    public static bool haveDoll = false;
    public GameObject water;
    public static bool haveWater = false;
    public GameObject water2;
    public static bool haveWater2 = false;
    Text moneyText;

    void Start()
    {
        //haveChocolate = true;
        //haveDoll = true;
        //haveWater = true;
        //haveWater2 = true;
        moneyText = GetComponent<Text>();
        moneyText.text = "money : " + moneyhave;
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "x " + moneyhave;
        if (haveChocolate == true)
        {
            chocolate.SetActive(true);
        }
        if (haveDoll == true)
        {
            doll.SetActive(true);    
        }
        if (haveWater == true)
        {
            water.SetActive(true);
        }
        if (haveWater2 == true)
        {
            water2.SetActive(true);
        }
        if (haveWater == false)
        {
            water.SetActive(false);
        }
        if (haveWater2 == false)
        {
            water2.SetActive(false);
        }
    }
}

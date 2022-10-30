using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class merchant : MonoBehaviour
{
    public GameObject MerchantUI1;
    public GameObject MerchantUI2;
    public GameObject MerchantTalk1;
    public GameObject MerchantTalk2;
    public GameObject ButtonC;
    public GameObject ButtonD;
    public GameObject ButtonW1;
    public GameObject ButtonW2;

    public int priceC = 50;
    public int priceD = 75;
    public int priceW = 10;
    public static bool canBuy = false;

    public void buychocolate()
    {
        if (itemmanager.moneyhave >= priceC)
        {
            itemmanager.haveChocolate = true;
            itemmanager.moneyhave -= priceC;
            MerchantTalk1.SetActive(false);
            MerchantTalk2.SetActive(false);
        }
        if (itemmanager.moneyhave < priceC)
        {
            MerchantTalk1.SetActive(true);
            MerchantTalk2.SetActive(true);
        }
    }
    public void buydoll()
    {
        if (itemmanager.moneyhave >= priceD)
        {
            itemmanager.haveDoll = true;
            itemmanager.moneyhave -= priceD;
            MerchantTalk1.SetActive(false);
            MerchantTalk2.SetActive(false);
        }
        if (itemmanager.moneyhave < priceD)
        {
            MerchantTalk1.SetActive(true);
            MerchantTalk2.SetActive(true);
        }
    }
    public void buywater1()
    {
        if (itemmanager.moneyhave >= priceW)
        {
            itemmanager.haveWater = true;
            itemmanager.moneyhave -= priceW;
            MerchantTalk1.SetActive(false);
            MerchantTalk2.SetActive(false);
        }
        if (itemmanager.moneyhave < priceW)
        {
            MerchantTalk1.SetActive(true);
            MerchantTalk2.SetActive(true);
        }
    }
    public void buywater2()
    {
        if (itemmanager.moneyhave >= 10)
        {
            itemmanager.haveWater2 = true;
            itemmanager.moneyhave -= 10;
            MerchantTalk1.SetActive(false);
            MerchantTalk2.SetActive(false);
        }
        if (itemmanager.moneyhave < 10)
        {
            MerchantTalk1.SetActive(true);
            MerchantTalk2.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "merchant 1(Clone)" || collider.gameObject.name == "merchant 1")
        {
            canBuy = true;
            Cursor.visible = true;
            MerchantUI1.SetActive(true);
        }
        if (collider.gameObject.name == "merchant 2" || collider.gameObject.name == "merchant 2(Clone)")
        {
            canBuy = true;
            Cursor.visible = true;
            MerchantUI2.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "merchant 1(Clone)" || collider.gameObject.name == "merchant 1")
        {
            canBuy = false;
            Cursor.visible = false;
            MerchantUI1.SetActive(false);
        }
        if (collider.gameObject.name == "merchant 2" || collider.gameObject.name == "merchant 2(Clone)")
        {
            canBuy = false;
            Cursor.visible = false;
            MerchantUI2.SetActive(false);
        }
    }
    void Start()
    {
        MerchantUI1.SetActive(false);
        MerchantTalk1.SetActive(false);
        MerchantTalk2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (itemmanager.haveChocolate == true)
        {
            ButtonC.SetActive(false);
        }
        if (itemmanager.haveDoll == true)
        {
            ButtonD.SetActive(false);
        }
        if (itemmanager.haveWater == true)
        {
            ButtonW1.SetActive(false);
        }
        if (itemmanager.haveWater2 == true)
        {
            ButtonW2.SetActive(false);
        }
    }
}

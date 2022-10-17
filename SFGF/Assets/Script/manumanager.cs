using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manumanager : MonoBehaviour
{
    public GameObject PauseUI;
    public GameObject ESCUI;
    public GameObject HowToPlayUI;
    float time = 0.0f;
    Text timeText;
    public void PlayGame()
    {
        SceneManager.LoadScene("PlayGame");
        Time.timeScale = 1; //เวลาในเกมเดินต่อ
    }
    public void openHowToPlay()
    {
        HowToPlayUI.SetActive(true);
    }
    public void closeHowToPlay()
    {
        HowToPlayUI.SetActive(false);
    }
    public void ResumeGame()
    {
        PauseUI.SetActive(false); //ปิดหน้าต่างหยุด
        Time.timeScale = 1; //เวลาในเกมเดินต่อ
        Cursor.visible = false;
    }
    public void RestarGame()
    {
        time = 0.0f;
        Time.timeScale = 1;
        Cursor.visible = false;
        friendmoney._friendmoney = 50;
        friendmoney2._friendmoney = 50;
        friendmoney3._friendmoney = 50;
        itemmanager.moneyhave = 0;
        itemmanager.haveChocolate = false;
        itemmanager.haveDoll = false;
        itemmanager.haveWater = false;
        itemmanager.haveWater2 = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void backgame()
    {
        SceneManager.LoadScene("Manu");
    }
    public void QuitGame()
    {
        Application.Quit(); // จะทำงานได้ต่อเมื่อเป็น .exe
    }
    // Start is called before the first frame update
    void Start()
    {
        //ESCUI.SetActive(true);
        PauseUI.SetActive(false);
        //GameoverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ESCUI.SetActive(false);
        }
        time = time + Time.deltaTime;
        timeText = GetComponent<Text>();
        timeText.text = "time : " + time.ToString("f1");
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1)
        {
            PauseUI.SetActive(true); //แสดงหน้าต่างหยุด
            Time.timeScale = 0; //หยุดเวลาในเกม
            Cursor.visible = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
        {
            ResumeGame();
        }
    }
}

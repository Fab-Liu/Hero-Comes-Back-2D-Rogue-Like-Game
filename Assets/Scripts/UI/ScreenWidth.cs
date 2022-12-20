using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScreenWidth : MonoBehaviour
{
    public float startTime = 0.0f;
    public float currentTime = 0.0f;
    public float increaseTime = 0.0f;
    public float tempTime = 0.0f;


    public float nextLeftTime = 0.0f;
    public float imageCoolDownTime = 5.0f;


    // TextMesh Pro
    public TextMeshProUGUI textMesh;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(960, 540, false);
        Screen.fullScreen = true;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.time;
        // wait for 3 seconds
        if (currentTime + increaseTime > 20.0f + startTime)
        {
            // load scene 1
            Application.LoadLevel("Level1");
        }
        else if (currentTime + increaseTime > 15.0f + startTime)
        {
            // change text mesh pro text
            textMesh.text = "Finally, after many long years, the hero could no longer ignore the suffering of the people and decided to return to the kingdom. Donning their old armor and wielding their trusty sword, the hero set out to challenge the sorcerer once again and restore peace to the land.";
        }
        else if (currentTime + increaseTime > 10.0f + startTime)
        {
            // change text mesh pro text
            textMesh.text = "Feeling defeated and unsure of what to do next, the hero withdrew from the kingdom and lived in seclusion for many years. But as the sorcerer's power grew stronger, the people of the kingdom began to lose hope.";
        }
        else if (currentTime + increaseTime > 5.0f + startTime)
        {

            // change text mesh pro text
            textMesh.text = "But one day, the hero met their greatest challenge yet: a powerful sorcerer who had cast a spell on the kingdom, causing chaos and destruction wherever they went. Despite their best efforts, the hero was unable to defeat the sorcerer and was forced to retreat.";
        }



        // 按空格increaseTime + 5
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentTime + increaseTime <= 5.0f)
            {
                tempTime = 5.0f - (currentTime + increaseTime);
                increaseTime += tempTime;
            }
            else if (currentTime + increaseTime <= 10.0f)
            {
                tempTime = 10.0f - (currentTime + increaseTime);
                increaseTime += tempTime;
            }
            else if (currentTime + increaseTime <= 15.0f)
            {
                tempTime = 15.0f - (currentTime + increaseTime);
                increaseTime += tempTime;
            }
            else if (currentTime + increaseTime <= 20.0f)
            {
                tempTime = 20.0f - (currentTime + increaseTime);
                increaseTime += tempTime;
            }
        }

        Debug.Log("tempTime: " + tempTime);
        Debug.Log("increaseTime: " + increaseTime);


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (currentTime < 5.0f)
            {
                increaseTime = 5.0f - currentTime;
            }
            else if (currentTime < 10.0f)
            {
                increaseTime = 10.0f - currentTime;
            }
            else if (currentTime < 15.0f)
            {
                increaseTime += 15.0f - currentTime;
            }
            else if (currentTime < 20.0f)
            {
                increaseTime += 20.0f - currentTime;
            }
        }

        nextLeftTime = (currentTime + increaseTime) % 5.0f;
        image.fillAmount = nextLeftTime / imageCoolDownTime;



    }
}

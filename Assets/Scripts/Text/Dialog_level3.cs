using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialog_level3 : MonoBehaviour
{
    //public Text speech;
    public Text button;
    public TextMeshProUGUI Text;
    public GameObject speech;
    public GameObject btn;

    private int index = 1;

    // Start is called before the first frame update
    void Start()
    {
       Text = speech.GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (index == 1) {
            //修改btn文字
            button.text = "ops...";
            //修改speech
            Text.text = "You have come a long way, hero, but your journey is not over yet.";
        }
        
        if (index == 2) {
            //修改btn文字
            button.text = "Yes, mayjor";
            //修改speech
            Text.text = "The big boss you are about to face is powerful and dangerous, but I have faith in your abilities. Remember everything I have taught you.";
        }

        if (index == 3) {
            button.text = "Hope so....";
            Text.text = "You can do this!";
        }

        if (index == 4) {
            button.text = "Got it!";
            Text.text = "The big boss may seem unbeatable, but every enemy has a weakness. Look for an opening in its defense and strike with all your might.";
        }

        if (index == 5) {
            button.text = "Thank you";
            Text.text = "And don't forget to use your special abilities wisely, they could be the key to victory.";
            Invoke("desDialog", 2f);
        }

        if(index == 6){
            desDialog();
        }
    }

    public void Next(){
        index++;
        Debug.Log("index = " + index);
    }

    void desDialog(){
        Debug.Log("here is working~~~");
        Destroy(this.gameObject);
        Time.timeScale = 1f;
    }
}

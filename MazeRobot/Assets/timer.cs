using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timer : MonoBehaviour
{
    public float timeLeft = 30.0f;
    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        txtMy.text = "test";
    }

    // Update is called once per frame
    void Update()
    {
        
        Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            int time = (int)timeLeft;
            txtMy.text = time.ToString();
        }
        else
        {
            txtMy.text = "Game over";
        }
    }
}

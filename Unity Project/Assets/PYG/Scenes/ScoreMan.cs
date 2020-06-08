using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //텍스트 메시프로 사용시
using System;

public class ScoreMan : MonoBehaviour
{
    //싱글톤 
   public static ScoreMan Instance;
   private void Awake() => Instance = this;

    public Text scoreTxt;
    public Text highScoreTxt;
    public TextMeshProUGUI textTxt; //텍스ㅡ메시프로 

    //public static int score;
    //private Text text;

    // private void Awake()
    // {
    //     text = GetComponent<Text>();
    //     score = 0;
    //         
    // }
    //
    // Update is called once per frame
    int score = 0;
    int highScore = 0;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreTxt.text = "HighSccore : " + highScore;
    }
    void Update()
    {
        //text.text = "Score : " + score;
        SaveHighScore();
    }

    private void SaveHighScore()
    {
       if(score> highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore" , highScore);
            highScoreTxt.text = "HighScore : " + highScore;
        }
    }

    public void AddScore()
    {
        score++;
        scoreTxt.text = "Score : " + score;

        //텍스트메시 프로는 안된다.
        textTxt.text = "text.........";
    }
}

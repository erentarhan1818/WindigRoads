using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class hightscore : MonoBehaviour
{
    public float highscore;
    public float score;


    public Text scoreText;
    public Text highscoreText;
   

    void Start()
    {
        highscore = PlayerPrefs.GetFloat("score");
        highscore = PlayerPrefs.GetFloat("hightscore");
    }
     void Update()
    {
        scoreText.text = score.ToString();
        highscoreText.text = highscore.ToString();

        if(score > highscore)
        {
            PlayerPrefs.SetFloat("hightscore", score);
        }
    }
}

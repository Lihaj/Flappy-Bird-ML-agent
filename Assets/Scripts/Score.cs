using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score;

    void Start()
    {
        score=0;
    }

    public void ScoreUp(){
        score++;
        GetComponent<Text>().text=score.ToString();
    }
    public void  ScoreRest(){
        score=0;
        GetComponent<Text>().text=score.ToString();
    }
   
}

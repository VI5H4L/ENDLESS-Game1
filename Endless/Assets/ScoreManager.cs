using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static int score;
    public Text scoreDisplay;

void Update(){
        scoreDisplay.text = score.ToString();
}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Obstacle")){
            score++;
        }
    }
}

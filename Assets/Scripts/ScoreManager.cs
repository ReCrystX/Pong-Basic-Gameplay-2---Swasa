using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int leftScore;
    public int rightScore;
    public int maxScore;

    public BallController ball;

    public void addLeftScore(int increment){
        rightScore += increment;
        ball.resetBall();
        if(rightScore >= maxScore){
            gameOver();
        }
    }

    public void addRightScore(int increment){
        leftScore += increment;
        ball.resetBall();
        if(leftScore >= maxScore){
            gameOver();
        }
    }

    public void gameOver(){
        SceneManager.LoadScene("Main menu");
    }
}
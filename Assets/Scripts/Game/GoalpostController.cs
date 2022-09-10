using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalpostController : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public ScoreManager manager;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision == ball){
            if(isRight){
                manager.addRightScore(1);
            }

            else{
                manager.addLeftScore(1);
            }
        }
    }
}
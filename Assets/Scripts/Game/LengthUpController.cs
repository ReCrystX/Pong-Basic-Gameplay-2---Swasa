using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LengthUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public PaddleController paddle1;
    public PaddleController paddle2;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision == ball){
            paddle1.time2 = 0;
            paddle2.time2 = 0;
            paddle1.LUp = true;
            paddle2.LUp = true;
        }
        manager.RemovePowerUp(gameObject);
    }
}

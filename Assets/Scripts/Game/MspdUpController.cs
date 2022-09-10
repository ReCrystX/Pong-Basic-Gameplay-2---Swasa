using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MspdUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public PaddleController paddle1;
    public PaddleController paddle2;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision == ball){
            paddle1.time1 = 0;
            paddle2.time1 = 0;
            paddle1.MspdUp = true;
            paddle2.MspdUp = true;
        }
        manager.RemovePowerUp(gameObject);
    }
}

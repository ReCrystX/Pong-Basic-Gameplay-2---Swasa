using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPos;

    private Rigidbody2D rig;

    private void Start(){
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void resetBall(){
        transform.position = new Vector3 (resetPos.x, resetPos.y, 2);
    }
}
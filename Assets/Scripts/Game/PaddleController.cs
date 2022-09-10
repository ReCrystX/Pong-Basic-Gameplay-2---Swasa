using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;

    public float time1 = 0;
    public bool MspdUp = false;

    private Vector3 LengthUp, Normal;
    public float time2 = 0;
    public bool LUp = false;

    private void Start(){
        rig = GetComponent<Rigidbody2D>();
        LengthUp = new Vector3(0.5f, 4f, 1f);
        Normal = new Vector3(0.5f, 2f, 1f);
    }

    private void Update()
    {
        if(!MspdUp){
            MoveObject(GetInput());
        }

        else if(MspdUp){
            MoveObject(SpeedUp());
            time1 += Time.deltaTime;
            if(time1 >= 5){
                time1 = 0;
                MspdUp = false;
            }
        }

        if(!LUp){
            transform.localScale = Normal;
        }

        else if(LUp){
            transform.localScale = LengthUp;
            time2 += Time.deltaTime;
            if(time2 >= 5){
                time2 = 0;
                LUp = false;
            }
        }
    }

    public Vector2 GetInput(){
        if(Input.GetKey(upKey)){
            return Vector2.up * speed;
        }

        else if(Input.GetKey(downKey)){
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    public Vector2 SpeedUp(){
        if(Input.GetKey(upKey)){
            return Vector2.up * speed * 2;
        }

        else if(Input.GetKey(downKey)){
            return Vector2.down * speed * 2;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement){
        Debug.Log("Paddle speed check: " + movement);
        rig.velocity = movement;
    }
}
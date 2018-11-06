using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carspeed : MonoBehaviour
{

    float speed, max_speed;
    // Use this for initialization
    void Start()
    {
        speed = 0f;
        max_speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            if (speed < 0.01f) speed = 0.01f;
            else if(speed < max_speed)speed *= 1.03f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 1);
            //회전
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -1);//회전
        }
        if (Input.GetKey(KeyCode.S))
        {//브레이크
            speed *= 0.95f;
        }

        transform.Translate(speed, 0, 0);
    }
}
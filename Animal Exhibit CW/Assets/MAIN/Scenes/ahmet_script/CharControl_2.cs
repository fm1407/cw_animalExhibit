using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;


public class CharControl_2 : MonoBehaviour
{
    public float speed = 10.0f;
    public float maxSpeed = 100.0f; //F = float value
    public float acc = 5.0f;
    public float dec = 5.0f;
    public float rotation = 0.0f;


    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey("up"))
        {
            if (speed < maxSpeed)  //ACCELERATE
                speed += acc;
        }
        else
        {
            if (speed > 0)        //DECELERATE
                speed -= dec;
        }
        transform.position += transform.forward * Time.deltaTime * speed;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -0.5f, 0);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0.5f, 0);
        }
    }
}

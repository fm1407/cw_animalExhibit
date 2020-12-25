using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingAnimation : MonoBehaviour
{
    static Animator anim;
    public float speed = 2.0f;
    public float rotationSpeed = 75.0f;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(translation, 0, 0);
        transform.Rotate(0, rotation, 0);


        if (translation != 0)
        {
            anim.SetBool("IsWalking", true);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
    }
}

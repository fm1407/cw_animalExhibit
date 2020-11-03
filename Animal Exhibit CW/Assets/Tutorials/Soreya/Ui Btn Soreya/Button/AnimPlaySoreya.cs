using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AnimPlaySoreya: MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {

            anim.Play("Walk", -1, 0f);
        }

        if (Input.GetMouseButtonDown(0))
        {

            anim.Play("Flip", -1, 0f);
        }

    }
}
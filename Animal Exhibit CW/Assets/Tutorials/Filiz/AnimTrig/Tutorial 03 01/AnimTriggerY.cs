using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTriggerY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            this.GetComponent<Animator>().Play("AnimY");
        }

    }

    private void OnMouseDown()
    {

        this.GetComponent<Animator>().Play("AnimY");
    }
}

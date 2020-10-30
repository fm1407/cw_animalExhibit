using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickTriggerImplode : MonoBehaviour
{
    public GameObject brickArray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        brickArray.GetComponent<Animator>().Play("Implode");
    }
}

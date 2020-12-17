using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quitApplication : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Application is closing");
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

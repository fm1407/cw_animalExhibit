using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit : MonoBehaviour
{
    public GameObject Exit_panel;
    public void OpenExitPanel()
    {
        if (Exit_panel != null)
        {
            Exit_panel.SetActive(true);
        }
    }
    void Start()
    {


    }


    void Update()
    {

    }
}

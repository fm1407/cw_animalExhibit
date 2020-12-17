using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panel : MonoBehaviour
{
    public GameObject Panel;
    public void OpenPanel()
    {
        if(Panel != null)
        {
            Panel.SetActive(true);
        }
    }
    void Start()
    {

      
    }
        

    void Update()
    {

    }
}

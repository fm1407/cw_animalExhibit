using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainToStingray : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("stingray");
    }
}



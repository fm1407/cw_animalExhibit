using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainToAnt : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("ant");
    }
}



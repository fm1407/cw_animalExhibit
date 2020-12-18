using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainToRobin : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("robin");
    }
}


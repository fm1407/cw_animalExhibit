using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainToSnake : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("snake");
    }
}



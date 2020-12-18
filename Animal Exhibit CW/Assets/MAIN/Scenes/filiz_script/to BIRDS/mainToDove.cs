using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainToDove : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("collared_dove");
    }
}


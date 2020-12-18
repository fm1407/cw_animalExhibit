using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainToGoldfish : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("goldfish");
    }
}


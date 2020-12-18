using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainToTrex : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("trex");
    }
}



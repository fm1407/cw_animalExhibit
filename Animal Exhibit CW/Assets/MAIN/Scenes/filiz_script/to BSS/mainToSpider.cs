﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainToSpider : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("spider");
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TemplateToMain : MonoBehaviour
{
    public void SceneSwitcher()
    {
        SceneManager.LoadScene("Main");
    }
}

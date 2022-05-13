using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour
{
    public void LoadFirstScene()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void LoadSecondScene()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void LoadThirdScene()
    {
        SceneManager.LoadScene("Level 3");
    }
}

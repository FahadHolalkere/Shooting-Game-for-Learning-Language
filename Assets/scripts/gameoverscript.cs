using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameoverscript : MonoBehaviour
{
    public GameObject gameo;
    public void gover()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }
    public void exit()
    {
        Application.Quit();
    }
}

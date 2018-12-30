using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {
    public void b1() {
        SceneManager.LoadSceneAsync(0);
    }
    public void b2()
    {
        Application.Quit();
    }
    public void b3()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void b4()
    {
        SceneManager.LoadSceneAsync(2);
    }
}

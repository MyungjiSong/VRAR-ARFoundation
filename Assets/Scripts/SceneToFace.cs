using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneToFace : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    public void ChangeToScene()
    {
        Console.WriteLine("Scene to test");
        SceneManager.LoadScene(SceneName);
    }
}

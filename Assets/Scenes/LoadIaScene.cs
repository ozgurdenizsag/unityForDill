using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadIaScene : MonoBehaviour
{
    public void LoadSceneIA()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

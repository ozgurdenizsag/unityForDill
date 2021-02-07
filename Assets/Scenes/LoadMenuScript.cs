using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadMenuScript : MonoBehaviour
{
    public void LoadHomeScene()
    {
        SceneManager.LoadScene("HomeScene");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGameScript : MonoBehaviour
{
    public void LoadActiveScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

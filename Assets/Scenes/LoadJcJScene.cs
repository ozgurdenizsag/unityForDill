using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadJcJScene : MonoBehaviour
{
    public void LoadSceneJcJ()
    {
        SceneManager.LoadScene("JoueurContreJoueur");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MissClickScript : MonoBehaviour
{
    
    public void MissClick()
    {
        if (SceneManager.GetActiveScene().name.Equals("IAScene"))
        {
            GameObject.Find("Canvas").GetComponent<GameManager>().joueurJoue.GetComponent<Text>().text = "Raté !";
            StartCoroutine(ExampleCoroutine());
        } else
        {
            GameObject.Find("Canvas").GetComponent<GameManager>().jcJCounter += 1;
            if (GameObject.Find("Canvas").GetComponent<GameManager>().jcJCounter % 2 == 0)
            {
                GameObject.Find("Canvas").GetComponent<GameManager>().joueurJoue.GetComponent<Text>().text = "Joueur 1 joue..";
            }
            else
            {
                GameObject.Find("Canvas").GetComponent<GameManager>().joueurJoue.GetComponent<Text>().text = "Joueur 2 joue..";
            }
        }
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("Canvas").GetComponent<GameManager>().ComputerPlay();
    }

}

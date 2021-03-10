using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissClickScript : MonoBehaviour
{
    
    public void jcjMissClick()
    {
        GameObject.Find("Canvas").GetComponent<GameManager>().jcJCounter += 1;
        if (GameObject.Find("Canvas").GetComponent<GameManager>().jcJCounter % 2 == 1)
        {
            GameObject.Find("Canvas").GetComponent<GameManager>().joueurJoue.GetComponent<Text>().text = "Joueur 1 joue..";
        }
        else
        {
            GameObject.Find("Canvas").GetComponent<GameManager>().joueurJoue.GetComponent<Text>().text = "Joueur 2 joue..";
        }
    }


    public void jIaMissClick()
    {
        GameObject.Find("Canvas").GetComponent<GameManager>().joueurJoue.GetComponent<Text>().text = "Raté !";
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("Canvas").GetComponent<GameManager>().joueurJoue.GetComponent<Text>().text = "FSF joue..";
        yield return new WaitForSeconds(2);
        GameObject.Find("Canvas").GetComponent<GameManager>().ComputerPlay();
        GameObject.Find("Canvas").GetComponent<GameManager>().joueurJoue.GetComponent<Text>().text = "Joueur 1 joue..";
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public void Select()
    {
        if (transform.Find("Text").GetComponent<Text>().text == "")
        {
            transform.Find("Text").GetComponent<Text>().text = "X";
            //GetComponent<Button>().interactable = false;
            int index = int.Parse(gameObject.name);
            GameObject.Find("Canvas").GetComponent<GameManager>().matrix[index] = "X";

        }
        if (GameObject.Find("Canvas").GetComponent<GameManager>().Verification("X"))
        {
            GameObject.Find("Canvas").GetComponent<GameManager>().ShowPanel("X");
        }
        else
        {
            GameObject.Find("Canvas").GetComponent<GameManager>().ComputerPlay();
        }

    }

    public void JcJScript()
    {
        int myLocalCounter = GameObject.Find("Canvas").GetComponent<GameManager>().jcJCounter;
        string myLocalMark = "X";
        if (myLocalCounter % 2 == 1)
        {
            myLocalMark = "O";
        }
        if (transform.Find("Text").GetComponent<Text>().text == "")
        {
            transform.Find("Text").GetComponent<Text>().text = myLocalMark;
            //GetComponent<Button>().interactable = false;
            int index = int.Parse(gameObject.name);
            GameObject.Find("Canvas").GetComponent<GameManager>().matrix[index] = myLocalMark;
        }
        if (GameObject.Find("Canvas").GetComponent<GameManager>().Verification(myLocalMark))
        {
            GameObject.Find("Canvas").GetComponent<GameManager>().ShowPanel(myLocalMark);
        }
        GameObject.Find("Canvas").GetComponent<GameManager>().jcJCounter += 1;
    }

}

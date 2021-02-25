using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public void Select()
    {

        Sprite sprite = GameObject.Find("Canvas").GetComponent<GameManager>().xSprite;
        string btnName = gameObject.name + "";
        if (transform.Find("Text").GetComponent<Text>().text == "")
        {
            transform.Find("Text").GetComponent<Text>().text = "X";
            int index = int.Parse(gameObject.name);
            GameObject.Find("Canvas").GetComponent<GameManager>().matrix[index] = "X";
            Button myButton = GameObject.Find(btnName).GetComponent<Button>();
            myButton.image.sprite = sprite;
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
        Sprite sprite = GameObject.Find("Canvas").GetComponent<GameManager>().xSprite;
        int myLocalCounter = GameObject.Find("Canvas").GetComponent<GameManager>().jcJCounter;
        string myLocalMark = "X";
        if (myLocalCounter % 2 == 1)
        {
            myLocalMark = "O";
            sprite = GameObject.Find("Canvas").GetComponent<GameManager>().oSprite;
        }
        if (transform.Find("Text").GetComponent<Text>().text == "")
        {
            transform.Find("Text").GetComponent<Text>().text = myLocalMark;
            int index = int.Parse(gameObject.name);
            string btnName = gameObject.name + "";
            GameObject.Find("Canvas").GetComponent<GameManager>().matrix[index] = myLocalMark;
            Button myButton = GameObject.Find(btnName).GetComponent<Button>();
            myButton.image.sprite = sprite;
            GameObject.Find("Canvas").GetComponent<GameManager>().matchNulCounter -= 1;

        }
        if (GameObject.Find("Canvas").GetComponent<GameManager>().Verification(myLocalMark))
        {
            GameObject.Find("Canvas").GetComponent<GameManager>().ShowPanel(myLocalMark);
        } else
        {
            if (GameObject.Find("Canvas").GetComponent<GameManager>().matchNulCounter == 0)
            {
                GameObject.Find("Canvas").GetComponent<GameManager>().GameOver.SetActive(true);
                GameObject.Find("Canvas").GetComponent<GameManager>().GameOver.transform.transform.Find("Text").GetComponent<Text>().text = "Match Nul";
            }
        }
        GameObject.Find("Canvas").GetComponent<GameManager>().jcJCounter += 1;

        
    }

}

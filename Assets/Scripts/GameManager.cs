using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public string[] matrix = new string[9];
    public List<int> choice = new List<int>();
    public int jcJCounter = 0;
    public GameObject GameOver;
    public Sprite xSprite;
    public Sprite oSprite;
    AI ai = new AI();
    public int matchNulCounter = 9;
    public Text joueurJoue;
    public string isIa = "non";


    public void ComputerPlay() {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        joueurJoue.GetComponent<Text>().text = "FSF joue..";
        yield return new WaitForSeconds(2);
        ComputerPlayed();
        joueurJoue.GetComponent<Text>().text = "FSF à joué !";
        yield return new WaitForSeconds(1);
        joueurJoue.GetComponent<Text>().text = "Tu joues..";
    }

    public void ComputerPlayed()
    {
        MajChoice();
        int nr = ai.BestMove("O", matrix);
        isIa = "oui";
        GameObject.Find(nr.ToString()).transform.Find("Text").GetComponent<Text>().text = "O";
        matrix[nr] = "O";
        Sprite sprite = GameObject.Find("Canvas").GetComponent<GameManager>().oSprite;
        string btnName = nr.ToString();
        Button myButton = GameObject.Find(btnName).GetComponent<Button>();
        myButton.image.sprite = sprite;

        if (Verification("O"))
        {
            ShowPanel("O");
        }
        else
        {
            MajChoice();
        }
    }

    void MajChoice()
    {
        choice.Clear();
        for(int i=0; i<matrix.Length; i++)
        {
            if (matrix[i] == "")
            {
                choice.Add(i);
            }
        }
        if (choice.Count == 0)
        {
            choice.Add(1);
            GameOver.SetActive(true);
            GameOver.transform.transform.Find("Text").GetComponent<Text>().text = "Match Nul";
            return;
        }
    }

    public bool Verification(string player)
    {
        if(matrix[0]==player && matrix[1] == player && matrix[2] == player ||
            matrix[3] == player && matrix[4] == player && matrix[5] == player ||
            matrix[6] == player && matrix[7] == player && matrix[8] == player ||

            matrix[0] == player && matrix[4] == player && matrix[8] == player ||
            matrix[2] == player && matrix[4] == player && matrix[6] == player ||

            matrix[0] == player && matrix[3] == player && matrix[6] == player ||
            matrix[1] == player && matrix[4] == player && matrix[7] == player ||
            matrix[2] == player && matrix[5] == player && matrix[8] == player )
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ShowPanel(string winner)
    {
        string gagnant;
        GameOver.SetActive(true);
        if ("X".Equals(winner))
        {
            if ("oui".Equals(isIa))
            {
                gagnant = "Tu as gagné !";
            }
            else
            {
                gagnant = "Joueur 1 a gagné";
            }
        } else
        {
            if("oui".Equals(isIa))
            {
                gagnant = "FSF a gagné";
            }else
            {
                gagnant = "Joueur 2 a gagné";
            }
            
        }
        joueurJoue.enabled = false;
        GameOver.transform.transform.Find("Text").GetComponent<Text>().text = gagnant;
        
    }

}

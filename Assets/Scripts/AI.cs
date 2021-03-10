using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI
{
    string[] tableau;
    List<int> choice = new List<int>();
    

    public int BestMove(string player, string[] matrix)
    {
        tableau = matrix;
        choice.Clear();

        for(int i = 0; i < tableau.Length; i++)
        {
            if (tableau[i] == "")
            {
                choice.Add(i);
                tableau[i] = player;

                if (CoupGagnant(player))
                {
                    return i;
                }
                tableau[i] = "";
            }
        }

        string adversaire = "X";
        if (player == "X")
        {
            adversaire = "O";
        }

        for (int i = 0; i < tableau.Length; i++)
        {
            if (tableau[i] == "")
            {
                tableau[i] = adversaire;

                if (CoupGagnant(adversaire))
                {
                    return i;
                }
                tableau[i] = "";
            }
        }
        if(choice.Count == 0) {
            choice.Add(1);
        }

        return choice[Random.Range(0, choice.Count)];
    }

    public bool CoupGagnant(string player)
    {
        if (tableau[0] == player && tableau[1] == player && tableau[2] == player ||
            tableau[3] == player && tableau[4] == player && tableau[5] == player ||
            tableau[6] == player && tableau[7] == player && tableau[8] == player ||

            tableau[0] == player && tableau[4] == player && tableau[8] == player ||
            tableau[2] == player && tableau[4] == player && tableau[6] == player ||

            tableau[0] == player && tableau[3] == player && tableau[6] == player ||
            tableau[1] == player && tableau[4] == player && tableau[7] == player ||
            tableau[2] == player && tableau[5] == player && tableau[8] == player)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

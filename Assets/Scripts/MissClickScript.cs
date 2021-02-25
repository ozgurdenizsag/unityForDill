using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissClickScript : MonoBehaviour
{
    
    public void jcjMissClick()
    {
        GameObject.Find("Canvas").GetComponent<GameManager>().jcJCounter += 1;
    }


    public void jIaMissClick()
    {
        GameObject.Find("Canvas").GetComponent<GameManager>().ComputerPlay();
    }
}

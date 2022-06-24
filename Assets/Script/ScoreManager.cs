using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int scorePlayer1;
    public int scorePlayer2;
    public int scorePlayer3;
    public int scorePlayer4;

    public void MinusScore1(int decrement)
    {
        scorePlayer1 -= decrement;
        if (scorePlayer1 <= 0)
        {
            Debug.Log("mati");
            // mati
        }
    }

    public void MinusScore2(int decrement)
    {
        scorePlayer2 -= decrement;
        if (scorePlayer2 <= 0)
        {
            Debug.Log("mati");
            // mati
        }
    }

    public void MinusScore3(int decrement)
    {
        scorePlayer3 -= decrement;
        if (scorePlayer3 <= 0)
        {
            Debug.Log("mati");
            // mati
        }
    }

    public void MinusScore4(int decrement)
    {
        scorePlayer4 -= decrement;
        if (scorePlayer4 <= 0)
        {
            Debug.Log("mati");
            // mati
        }
    }

    
}

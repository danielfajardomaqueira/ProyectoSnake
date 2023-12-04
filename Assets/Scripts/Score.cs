using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score
{
    public const string HIGH_SCORE = "highScore"; //clave en PlayerPrefs

    //public int score; // Puntuación del jugador

    public static int GetHighScore()
    {
        return PlayerPrefs.GetInt(HIGH_SCORE, 0);
    }

    public static bool TrySetNewHighScore(int score)
    {
        int highScore = GetHighScore();
        if(score > highScore)
        {
            // Modificamos el High Score
            PlayerPrefs.SetInt(HIGH_SCORE, score);
            PlayerPrefs.Save();
            return true;
        }
        return false;
    }

    public static void InitializeStaticScore()
    {

    }
}

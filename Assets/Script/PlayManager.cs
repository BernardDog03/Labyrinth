using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    [SerializeField] GameObject FinishedCanvas;
    [SerializeField] TMP_Text finishedText;
    int coin = 100;
    public void GameOver()
    {
        finishedText.text = "You Failed!";
        FinishedCanvas.SetActive(true);
    }

    public void PlayerWin()
    {
        finishedText.text = "You Win! \nScore: " + GetScore();
        FinishedCanvas.SetActive(true);
    }

    private int GetScore()
    {
        return coin * 10;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScoreToUI : MonoBehaviour
{
    public Text addPlayer1Score, addPlayer2Score, addPlayer3Score, addPlayer4Score;
    public ScoreManager manager;
    

    // Update is called once per frame
    void Update()
    {
        addPlayer1Score.text = manager.player1Score.ToString();
        addPlayer2Score.text = manager.player2Score.ToString();
        addPlayer3Score.text = manager.player3Score.ToString();
        addPlayer4Score.text = manager.player4Score.ToString();
    }
}

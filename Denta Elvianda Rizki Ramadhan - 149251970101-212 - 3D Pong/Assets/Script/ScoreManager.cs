using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int player1Score, player2Score, player3Score, player4Score;
    public int maxScore;
    public WallManager wall;
    public PlayerManager player;
    private bool player1Lose, player2Lose, player3Lose, player4Lose;
    // Start is called before the first frame update
    void Start()
    {
        

    }
    public void player1AddScore(int increment)
    {
        player1Score += increment;
        if(player1Score == maxScore)
        {
            wall.MovewallBottom();
            player.Deactivateplayer1();
            player1Lose = true;
        }
    }
    public void player2AddScore(int increment)
    {
        player2Score += increment;
        if(player2Score == maxScore)
        {
            wall.MovewallUp();
            player.Deactivateplayer2();
            player2Lose = true;
        }
    }
    public void player3AddScore(int increment)
    {
        player3Score += increment;
        if(player3Score == maxScore)
        {
            wall.MovewallLeft();
            player.Deactivateplayer3();
            player3Lose = true;
        }
    }
    public void player4AddScore(int increment)
    {
        player4Score += increment;
        if(player4Score == maxScore)
        {
            wall.MovewallRight();
            player.Deactivateplayer4();
            player4Lose = true;
        }
    }

    public void WinningCondition()
    {
        if(player2Lose == true && player3Lose == true && player4Lose == true)
        {
            Debug.Log("Player 1 WIN !");
        }
        else if (player1Lose == true && player3Lose == true && player4Lose == true)
        {
            Debug.Log("Player 2 WIN !");
        }
        else if(player1Lose == true && player2Lose == true && player4Lose == true)
        {
            Debug.Log("Player 3 WIN !");
        }
        else if(player1Lose == true && player2Lose == true && player3Lose == true)
        {
            Debug.Log("Player 4 WIn !");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

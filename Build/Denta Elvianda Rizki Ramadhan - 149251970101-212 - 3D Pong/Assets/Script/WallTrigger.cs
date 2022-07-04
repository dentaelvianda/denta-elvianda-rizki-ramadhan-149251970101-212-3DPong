using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ePlayer
{
    Bottom,
    Left,
    Right,
    Up,
}
public class WallTrigger : MonoBehaviour
{
    //public SphereCollider ball;
    public ePlayer player;
    public ScoreManager manager;
    public GameObject ball;
    
    private void OnTriggerEnter(Collider collision)
    {
        if(collision == ball)
        {
            ball.SetActive(false);
        }
            
            if (player == ePlayer.Up)
            {
                manager.player2AddScore(1);
            }
            if (player == ePlayer.Bottom)
            {
                manager.player1AddScore(1);
            }
            if (player == ePlayer.Left)
            {
                manager.player3AddScore(1);
            }
            if (player == ePlayer.Right)
            {
                manager.player4AddScore(1);
            }
        
        
    }
}

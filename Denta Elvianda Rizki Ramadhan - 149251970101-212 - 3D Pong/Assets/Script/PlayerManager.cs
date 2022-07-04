using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject player1, player2, player3, player4;
    public void Deactivateplayer1()
    {
        player1.SetActive(false);
    }
    public void Deactivateplayer2()
    {
        player2.SetActive(false);
    }
    public void Deactivateplayer3()
    {
        player3.SetActive(false);
    }
    public void Deactivateplayer4()
    {
        player4.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    public GameObject wallBottom, wallUp, wallLeft, wallRight;


    public void MovewallBottom()
    {
        transform.position = new Vector3(transform.position.x, 4.74f, transform.position.z);
    }
    public void MovewallUp()
    {
        transform.position = new Vector3(transform.position.x, 4.74f, transform.position.z);
    }
    public void MovewallLeft()
    {
        transform.position = new Vector3(transform.position.x, 4.74f, transform.position.z);
    }
    public void MovewallRight()
    {
        transform.position = new Vector3(transform.position.x, 4.74f, transform.position.z);
    }
}
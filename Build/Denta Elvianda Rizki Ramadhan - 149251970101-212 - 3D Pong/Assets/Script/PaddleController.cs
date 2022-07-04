using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public string left, right,up,down;
    public float speed;
  public bool isHorizontal;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(isHorizontal == true)
    {
            if (Input.GetKey(up))
            {

                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
                
                
            }
            else if (Input.GetKey(down))
            {
                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            }
       }

        else
        {
            if (Input.GetKey(left))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));

        }
        else if (Input.GetKey(right))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleVertical : MonoBehaviour
{
    public string up, down;
    public float speed;
   //ublic float zboundaryUp, zboundaryDown;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(up))
        {
            transform.Translate(new Vector3(speed * Time.fixedDeltaTime, 0, 0));
        }
        else if (Input.GetKey(down))
        {
            transform.Translate(new Vector3(-speed * Time.fixedDeltaTime, 0, 0));
        }

        

    }
}

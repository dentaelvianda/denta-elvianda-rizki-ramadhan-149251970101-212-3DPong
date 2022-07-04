using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleHorizontal : MonoBehaviour
{
    public string left, right, up, down;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

            if (Input.GetKey(left))
            {
                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));

            }
            else if (Input.GetKey(right))
            {
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
        if (Input.GetKey(up))
        {
            transform.Translate(new Vector3(0,0, speed * Time.deltaTime));

        }
        else if (Input.GetKey(down))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMov : MonoBehaviour
{
    public float speedOfMov;
    public bool toRight;
    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3(speedOfMov, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speedOfMov, 0, 0);
        }

        if (transform.position.x > 8)
        {
            toRight = false;
        }
        if (transform.position.x < -3)
        {
            toRight = true;
        }
    }
}

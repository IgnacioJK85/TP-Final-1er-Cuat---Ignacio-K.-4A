using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMov : MonoBehaviour
{
    public GameObject blueCube1;
    public GameObject blueCube2;
    public GameObject blueCube3;
    public GameObject blueCube4;
    public GameObject blueCube5;
    public float speedOfMov;
    public bool toRight;
    
    // Start is called before the first frame update
    void Start()
    {
        toRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            blueCube1.transform.position += new Vector3(0, 0, speedOfMov);
            blueCube3.transform.position += new Vector3(0, 0, speedOfMov);
            blueCube5.transform.position += new Vector3(0, 0, speedOfMov);

            blueCube2.transform.position -= new Vector3(0, 0, speedOfMov);
            blueCube4.transform.position -= new Vector3(0, 0, speedOfMov);
        }
        else
        {
            blueCube1.transform.position -= new Vector3(0, 0, speedOfMov);
            blueCube3.transform.position -= new Vector3(0, 0, speedOfMov);
            blueCube5.transform.position -= new Vector3(0, 0, speedOfMov);

            blueCube2.transform.position += new Vector3(0, 0, speedOfMov);
            blueCube4.transform.position += new Vector3(0, 0, speedOfMov);
        }

        if (blueCube1.transform.position.z < -14.7f && blueCube3.transform.position.z < -14.7f && blueCube5.transform.position.z < -14.7f)
        {
            toRight = false;
        }
        if (blueCube2.transform.position.z > 16.4f && blueCube4.transform.position.z > 16.4f)
        {
            toRight = true;
        }

        if (blueCube1.transform.position.z > 16.4f && blueCube3.transform.position.z > 16.4f && blueCube5.transform.position.z > 16.4f)
        {
            toRight = false;
        }


    }
}

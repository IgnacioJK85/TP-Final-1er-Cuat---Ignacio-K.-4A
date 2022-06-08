using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsClone : MonoBehaviour
{
    public GameObject objectToClone;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(objectToClone);
    }

}

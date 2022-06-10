using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsClone : MonoBehaviour
{
    Rigidbody rbBala;
    public float ShotForce;
    public GameObject objectToClone;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject clon;
        clon = Instantiate(objectToClone);
        rbBala = clon.GetComponent<Rigidbody>();
        rbBala.AddForce(clon.transform.up * ShotForce, ForceMode.Impulse);
        Destroy(clon, 1);
    }

}

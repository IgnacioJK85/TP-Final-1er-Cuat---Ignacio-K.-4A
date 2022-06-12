using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsClone : MonoBehaviour
{
    Rigidbody rbBala;
    public float ShotForce;
    public GameObject BulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        rbBala = BulletPrefab.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        BulletPrefab = Instantiate(BulletPrefab) as GameObject;
        rbBala.AddForce(transform.forward * ShotForce * Time.deltaTime);
    }
}

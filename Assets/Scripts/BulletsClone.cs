using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsClone : MonoBehaviour
{
    public Transform spawnPoint;
    public float shortForce = 1500;
    public float shotRate = 0.5f;
    private float shotRateTime = 0;

    public float ShotForce;
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject newBullet;
            newBullet = Instantiate(BulletPrefab, spawnPoint.position, spawnPoint.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shortForce);
            shotRateTime = Time.time + shotRate;
            Destroy(newBullet, 2);
        }
    }
}

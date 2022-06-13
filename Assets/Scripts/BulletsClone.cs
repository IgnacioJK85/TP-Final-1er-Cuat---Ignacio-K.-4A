using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsClone : MonoBehaviour
{
    public Text txt;
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
        if (Input.GetKeyDown(KeyCode.L))
        {
            GameObject newBullet;
            newBullet = Instantiate(BulletPrefab, spawnPoint.position, spawnPoint.rotation);
            //newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shortForce);
            //shotRateTime = Time.time + shotRate;
            //Destroy(newBullet, 2);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == BulletPrefab)
        {
            string txtt = txt.text;
            int txtnum = int.Parse(txtt);
            txtnum = txtnum - 30;

            string txttt = txtnum.ToString();
            txt.text = txttt;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsClone : MonoBehaviour
{
    public float Timer = 3f;
    //public Text txt;
    public GameObject myCube;
    public Transform spawnPoint;
    public float shortForce = 1500;
    public float shotRate = 0.5f;
    private float shotRateTime = 0;
    public float c = 4f;
    public float ShotForce;
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1f)
        {
            spawnPoint.Rotate(45.0f, 0.0f, 0.0f, Space.Self);
            for (int i = 0; i < 2; i++)
            {
                var distance = Vector3.Distance(BulletPrefab.transform.position, transform.position);
                Timer -= Time.deltaTime;

                if (Timer <= 0f && distance > c)
                {
                    Instantiate(BulletPrefab, spawnPoint.position, spawnPoint.rotation);
                    Timer = 3f;
                }

                //newBullet = Instantiate(BulletPrefab, spawnPoint.position, spawnPoint.rotation);
                //newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shortForce);
                //shotRateTime = Time.time + shotRate;
                //Destroy(newBullet, 2);
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        /*if (col.gameObject.name == "Bullets")
        {
            string txtt = txt.text;
            int txtnum = int.Parse(txtt);
            txtnum = txtnum - 30;

            string txttt = txtnum.ToString();
            txt.text = txttt;
        }*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsClone : MonoBehaviour
{
    public float ShotForce;
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(reloadTime(5));
    }

    // Update is called once per frame
    void Update()
    { 
        BulletPrefab = Instantiate(BulletPrefab);

        for (int i = 0; i < 3; i++)
        {
            BulletPrefab.transform.position += new Vector3(5, 0, 0);
        }
    }
    IEnumerator reloadTime(float reloadTimeInSeconds)
    {
        float counter = 0;

        while (counter < reloadTimeInSeconds)
        {
            counter += Time.deltaTime;
            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float Timerr = 30f;
    public Text txtnivel1;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        Timerr -= Time.deltaTime;
        txtnivel1.enabled = true;

        if (Timerr <= 0f)
        {
            txtnivel1.enabled = false;
        }
    }

    /*IEnumerator time()
    {

        txtnivel1.enabled = true;
        yield return new WaitForSeconds(1);
        txtnivel1.enabled = false;  
    }*/
}

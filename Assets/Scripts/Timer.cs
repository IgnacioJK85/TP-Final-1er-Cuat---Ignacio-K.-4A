using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text txtnivel1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(tiempo()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator tiempo()
    {
        txtnivel1.enabled = true;
        yield return new WaitForSeconds(1);
        txtnivel1.enabled = false;  
    }
}

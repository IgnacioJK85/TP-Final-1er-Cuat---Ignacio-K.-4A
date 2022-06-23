using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
    }
    public void SceneMenú()
    {
        SceneManager.LoadScene("Menú");
    }
    public void SceneDeath()
    {
        SceneManager.LoadScene("Death");
    }
    public void SceneNivel1()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void WinNivel1MorirEnNivel2()
    {
        SceneManager.LoadScene("Nivel2");
    }
}

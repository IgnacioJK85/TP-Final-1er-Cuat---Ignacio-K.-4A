using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2f)
        {
            CallDeath();
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.StartsWith("BlueCube"))
        {
            int txtint = int.Parse(txt.text);
            txtint--;

            if (txtint <= 0)
            {
                CallDeath();
            }
            else
            {
                txt.text = txtint.ToString();
            }
        }

        if (col.gameObject.name == "Goal1")
        {
            SceneManagerScript win = new SceneManagerScript();
            win.WinNivel1MorirEnNivel2();
        }
    }

    void CallDeath()
    {
        SceneManagerScript scenes = new SceneManagerScript();
        scenes.SceneDeath();
    }
}

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
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            Destroy(gameObject);    
        }

        if (col.gameObject.name.StartsWith("BlueCube"))
        {
            int txtj = int.Parse(txt.text);
            txtj -= 33;

            if (txtj <= 0)
            { 
                SceneManagerScript scenes = new SceneManagerScript();
                scenes.SceneDeath();
            }
            else
            {
                string a = txtj.ToString();
                txt.text = a;
            }
        }
    }
}

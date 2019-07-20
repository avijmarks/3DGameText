using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTextDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameText.generator.CreateNode("THIS IS YOUR TEXT", GameText.generator.style_Button, this.transform, new Vector3(0f, 1f, 2.5f), new Vector3(0f, 180f, 0f));
        //GameText.GameTextStyle("DemoStyle", .6, 1, false, false, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

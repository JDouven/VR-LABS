using UnityEngine;
using System.Collections;

public class JoystickTextureSwitch : MonoBehaviour {

    private TextureSwitcher[] scripts;
	// Use this for initialization
	void Start () {
        scripts = GetComponentsInChildren<TextureSwitcher>();
	}
	
	// Update is called once per frame
	void Update () {
        //On press of the 'X' button on the XBOX One controller
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            foreach(TextureSwitcher ts in scripts)
            {
                ts.SwitchTextures();
            }
        }
	}
}

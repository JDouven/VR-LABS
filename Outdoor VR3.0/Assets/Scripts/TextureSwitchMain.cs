using UnityEngine;
using System.Collections;

public abstract class TextureSwitchMain : MonoBehaviour
{

    protected TextureSwitcher[] scripts;
    // Use this for initialization
    public abstract void Start();

    public void Switch()
    {
        foreach (TextureSwitcher ts in scripts)
        {
            ts.SwitchTextures();
        }
    }
}

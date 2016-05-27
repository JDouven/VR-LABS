using UnityEngine;
using System.Collections;
using System;

public class TextureSwitchShoes : TextureSwitchMain
{
    public override void Start()
    {
        scripts = GetComponentsInChildren<TextureSwitcher>();
    }
}

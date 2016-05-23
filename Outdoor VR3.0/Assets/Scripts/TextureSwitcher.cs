using UnityEngine;
using System.Collections;

public class TextureSwitcher : MonoBehaviour
{

    public Material material1;
    public Material material2;

    private new Renderer renderer;

    public void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    public void SwitchTextures()
    {
        if(renderer.material.mainTexture == material1.mainTexture)
        {
            renderer.material = material2;
        }
        else if(renderer.material.mainTexture == material2.mainTexture)
        {
            renderer.material = material1;
        }
    }
}

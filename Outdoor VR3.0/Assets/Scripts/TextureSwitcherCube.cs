using UnityEngine;
using System.Collections;

public class TextureSwitcherCube : MonoBehaviour
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
        if (renderer.material.color == material1.color)
        {
            renderer.material = material2;
        }
        else if (renderer.material.color == material2.color)
        {
            renderer.material = material1;
        }
    }
}

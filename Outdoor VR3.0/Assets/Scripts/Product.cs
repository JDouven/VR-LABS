using UnityEngine;
using System.Collections;

public class Product : MonoBehaviour
{
    public Material material1;
    public Material material2;
    public GameObject colorChanger1;
    public GameObject colorChanger2;

    [HideInInspector]
    public ColorSwitcher switcher;

    private new Renderer renderer;
    private TextureSwitchMain ts;

    public void Awake()
    {
        renderer = GetComponent<Renderer>();
        if(renderer == null)
        {
            ts = GetComponent<TextureSwitchMain>();
        }
        colorChanger1 = GetComponent<GameObject>();
        colorChanger2 = GetComponent<GameObject>();
    }

    public void SetActive(bool active)
    {
        gameObject.SetActive(active);
        switcher.enabled = active;
        //colorChanger1.SetActive(active);
        //colorChanger2.SetActive(active);
    }

    public bool IsActive()
    {
        return gameObject.activeSelf;
    }


    public void SwitchTextures()
    {
        if (renderer != null)
        {
            if (renderer.material.mainTexture == material1.mainTexture)
            {
                renderer.material = material2;
            }
            else if (renderer.material.mainTexture == material2.mainTexture)
            {
                renderer.material = material1;
            }
        }
        else
        {
            ts.Switch();
        }
    }
}

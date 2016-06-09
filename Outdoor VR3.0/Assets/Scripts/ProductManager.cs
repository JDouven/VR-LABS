using UnityEngine;
using System.Collections;

public class ProductManager : MonoBehaviour
{
    public Product shoes1;
    public Product shoes2;
    public Product tent1;
    public Product tent2;
    public GameObject colorChanger1;
    public GameObject colorChanger2;

    private ColorSwitcher shoes1Switcher;
    private ColorSwitcher shoes2Switcher;
    private ColorSwitcher tent1Switcher;
    private ColorSwitcher tent2Switcher;

    // Use this for initialization
    void Awake()
    {
        shoes1Switcher = GameObject.Find("MenuItem (1)").GetComponentInChildren<ColorSwitcher>();
        shoes2Switcher = GameObject.Find("MenuItem (2)").GetComponentInChildren<ColorSwitcher>();
        tent1Switcher = GameObject.Find("MenuItem (3)").GetComponentInChildren<ColorSwitcher>();
        tent2Switcher = GameObject.Find("MenuItem (4)").GetComponentInChildren<ColorSwitcher>();;

        shoes1.switcher = shoes1Switcher;
        shoes2.switcher = shoes2Switcher;
        tent1.switcher = tent1Switcher;
        tent2.switcher = tent2Switcher;

        shoes1.SetActive(false);
        shoes2.SetActive(false);
        tent1.SetActive(false);
        tent2.SetActive(false);
    }

    public void ToggleShoes1()
    {
        if (shoes1.IsActive())
        {
            shoes1.SetActive(false);
        }
        else
        {
            shoes1.SetActive(true);

            shoes2.SetActive(false);
            tent1.SetActive(false);
            tent2.SetActive(false);
        }
    }

    public void ToggleShoes2()
    {
        if (shoes2.IsActive())
        {
            shoes2.SetActive(false);
        }
        else
        {
            shoes2.SetActive(true);

            shoes1.SetActive(false);
            tent1.SetActive(false);
            tent2.SetActive(false);
        }
    }

    public void ToggleTent1()
    {
        if (tent1.IsActive())
        {
            tent1.SetActive(false);            
        }
        else
        {
            tent1.SetActive(true);

            shoes1.SetActive(false);
            shoes2.SetActive(false);
            tent2.SetActive(false);
        }
    }

    public void ToggleTent2()
    {
        if (tent2.IsActive())
        {
            tent2.SetActive(false);
        }
        else
        {
            tent2.SetActive(true);

            shoes1.SetActive(false);
            shoes2.SetActive(false);
            tent1.SetActive(false);
        }
    }

    public void ToggleShoes1Color()
    {
        shoes1.SwitchTextures();
    }

    public void ToggleShoes2Color()
    {
        shoes2.SwitchTextures();
    }

    public void ToggleTent1Color()
    {
        tent1.SwitchTextures();
    }

    public void ToggleTent2Color()
    {
        tent2.SwitchTextures();
    }
}

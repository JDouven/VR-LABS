using UnityEngine;
using System.Collections;

public class ProductManager : MonoBehaviour
{
    public Product shoes1;
    public Product shoes2;
    public Product tent1;
    public Product tent2;

    // Use this for initialization
    void Start()
    {

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

    }

    public void ToggleShoes2Color()
    {

    }

    public void ToggleTent1Color()
    {

    }

    public void ToggleTent2Color()
    {

    }
}

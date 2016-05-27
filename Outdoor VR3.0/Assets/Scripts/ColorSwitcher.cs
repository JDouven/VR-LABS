using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

public class ColorSwitcher : MonoBehaviour
{
    public SelectionRadial selectionRadial;

    private VRInteractiveItem events;
    private bool gazeOver = false;
    private MenuTile.ProductType type;
    private TextureSwitcherCube texSwitch;
    private ProductManager manager;

    // Use this for initialization
    void Awake()
    {
        events = GetComponent<VRInteractiveItem>();
        type = GetComponentInParent<MenuTile>().type;
        texSwitch = GetComponent<TextureSwitcherCube>();
        manager = GetComponentInParent<Transform>().GetComponentInParent<ProductManager>();
    }

    public void OnEnable()
    {
        events.OnOver += HandleOver;
        selectionRadial.OnSelectionComplete += HandleSelectionComplete;
        events.OnOut += HandleOut;
    }

    public void OnDisable()
    {
        events.OnOver -= HandleOver;
        selectionRadial.OnSelectionComplete -= HandleSelectionComplete;
        events.OnOut -= HandleOut;
    }

    public void HandleOver()
    {
        selectionRadial.Show();
        selectionRadial.HandleDown();
        gazeOver = true;
    }

    public void HandleSelectionComplete()
    {
        if (gazeOver)
        {
            //Switch colors of block and switch product color
            texSwitch.SwitchTextures();
            switch (type)
            {
                case MenuTile.ProductType.shoe1:
                    manager.ToggleShoes1Color();
                    break;
                case MenuTile.ProductType.shoe2:
                    manager.ToggleShoes2Color();
                    break;
                case MenuTile.ProductType.tent1:
                    manager.ToggleTent1Color();
                    break;
                case MenuTile.ProductType.tent2:
                    manager.ToggleTent2Color();
                    break;
            }
            selectionRadial.Hide();
        }
    }

    public void HandleOut()
    {
        gazeOver = false;
        selectionRadial.HandleUp();
        selectionRadial.Hide();
    }
}

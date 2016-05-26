using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

public class MenuTile : MonoBehaviour
{
    public SelectionRadial selectionRadial;
    public ProductManager manager;
    public ProductType type;

    private VRInteractiveItem events;
    private bool gazeOver = false;

    public enum ProductType
    {
        shoe1,
        shoe2,
        tent1,
        tent2
    }

    // Use this for initialization
    void Awake()
    {
        events = GetComponent<VRInteractiveItem>();
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
            switch (type)
            {
                case ProductType.shoe1:
                    manager.ToggleShoes1();
                    break;
                case ProductType.shoe2:
                    manager.ToggleShoes2();
                    break;
                case ProductType.tent1:
                    manager.ToggleTent1();
                    break;
                case ProductType.tent2:
                    manager.ToggleTent2();
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

    // Update is called once per frame
    void Update()
    {

    }
}

using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

public class BuyButton : MonoBehaviour
{
    public SelectionRadial selectionRadial;

    private VRInteractiveItem events;
    private bool gazeOver = false;

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
            //Bought
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

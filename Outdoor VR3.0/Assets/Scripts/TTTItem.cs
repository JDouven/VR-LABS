using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;
using System;

public class TTTItem : MonoBehaviour
{
    public tttType type = tttType.none;
    public SelectionRadial selectionRadial;

    public event Action OnMoveMade;

    private VRInteractiveItem events;
    private new Renderer renderer;
    private TTTController controller;
    private bool gazeOver = false;

    public enum tttType
    {
        X,
        O,
        none
    }

    void Awake()
    {
        events = GetComponent<VRInteractiveItem>();
        renderer = GetComponent<Renderer>();
        controller = GetComponentInParent<TTTController>();
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
        gazeOver = true;
    }

    public void HandleSelectionComplete()
    {
        if (gazeOver)
        {
            if (type == tttType.none)
            {
                if (controller.xTurn)
                {
                    type = tttType.X;
                    controller.xTurn = false;
                }
                else
                {
                    type = tttType.O;
                    controller.xTurn = true;
                }
            }
            OnMoveMade();
            selectionRadial.Hide();
        }
    }

    public void HandleOut()
    {
        gazeOver = false;
        selectionRadial.Hide();
    }

    public void Update()
    {
        if (type == tttType.X)
        {
            renderer.material = controller.xMaterial;
        }
        else if (type == tttType.O)
        {
            renderer.material = controller.oMaterial;
        }
        else // if(type == tttType.none)
        {
            renderer.material = controller.blankMaterial;
        }
    }
}

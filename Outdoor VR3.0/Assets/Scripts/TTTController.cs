using System.Collections;
using UnityEngine;

public class TTTController : MonoBehaviour
{

    public Material xMaterial;
    public Material oMaterial;
    public Material blankMaterial;
    public TTTItem[] ticTacToeItems = new TTTItem[9];

    [HideInInspector]
    public bool xTurn = true;

    private TTTItem[][] items = new TTTItem[3][];
    private TTTItem.tttType winner = TTTItem.tttType.none;

    // Use this for initialization
    void Start()
    {
        PopulateArray();
    }

    private void PopulateArray()
    {
        for (int i = 0; i < 3; i++)
        {
            items[i] = new TTTItem[3];
        }
        for (int i = 0; i < ticTacToeItems.Length; i++)
        {
            ticTacToeItems[i].OnMoveMade += OnMoveMade;

            if (i / 3 < 1)
            {
                items[i][0] = ticTacToeItems[i];
            }
            else if (i / 3 >= 1 && i / 3 < 2)
            {
                items[i % 3][1] = ticTacToeItems[i];
            }
            else if (i / 3 >= 2)
            {
                items[i % 3][2] = ticTacToeItems[i];
            }
        }
    }

    private void OnMoveMade()
    {
        CheckWin();
    }

    private void CheckWin()
    {
        TTTItem.tttType winner = TTTItem.tttType.none;
        for (int i = 0; i < 3; i++)
        {
            //Check vertical rows
            if ((items[0][i].type == items[1][i].type) && (items[1][i].type == items[2][i].type))
            {
                if (items[1][i].type != TTTItem.tttType.none)
                {
                    winner = items[1][i].type;
                }
            }
            //Check horizontal rows
            else if ((items[i][0].type == items[i][1].type) && (items[i][1].type == items[i][2].type))
            {
                if (items[i][1].type != TTTItem.tttType.none)
                {
                    winner = items[i][1].type;
                }
            }
        }
        //Check diagonals
        if ((items[0][0].type == items[1][1].type) && (items[1][1].type == items[2][2].type))
        {
            if (items[1][1].type != TTTItem.tttType.none)
            {
                winner = items[1][1].type;
            }
        }
        else if ((items[2][0].type == items[1][1].type) && (items[1][1].type == items[0][2].type))
        {
            if (items[1][1].type != TTTItem.tttType.none)
            {
                winner = items[1][1].type;
            }
        }
        //Check if winner or just empty rows
        if (winner != TTTItem.tttType.none)
        {
            this.winner = winner;
            StartCoroutine(EndGame());
        }
    }

    private IEnumerator EndGame()
    {
        if (winner != TTTItem.tttType.none)
        {
            foreach (TTTItem item in ticTacToeItems)
            {
                item.type = winner;
            }
        }
        yield return new WaitForSeconds(5);
        foreach (TTTItem item in ticTacToeItems)
        {
            item.type = TTTItem.tttType.none;
        }
        winner = TTTItem.tttType.none;
    }
}

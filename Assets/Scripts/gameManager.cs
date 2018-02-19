using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public BoardManager boardScript;

    private int level = 3; //starting level

    void Awake()
    {
        boardScript = GetComponent<BoardManager>();
        InitGame();
    }

    void InitGame()
    {
        boardScript.SetupScene(level);
    }
}
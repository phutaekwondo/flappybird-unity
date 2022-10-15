using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConfig : MonoBehaviour
{
    [SerializeField] static public float Speed = 2f;
    static public bool isMovingGround = false;
    static public bool isMovingObstacles = false;
    static public bool isBirdFalling = false;
    static public bool isSpawingObstacle = false;

    //declare the currentGameState variable
    static public StateManager.GameState currentGameState = StateManager.GameState.Waiting;

    static public void LogAllInfo()
    {
        Debug.Log("Speed: " + Speed);
        Debug.Log("isMovingGround: " + isMovingGround);
        Debug.Log("isMovingObstacles: " + isMovingObstacles);
        Debug.Log("isBirdFalling: " + isBirdFalling);
        Debug.Log("isSpawingObstacle: " + isSpawingObstacle);
    }
}

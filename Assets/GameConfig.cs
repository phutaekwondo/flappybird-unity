using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConfig : MonoBehaviour
{
    [SerializeField] static public float Speed = 2f;

    static public uint Score = 1;

    //these variables below are used to control the state of the game
    static public bool isMovingGround = false;
    static public bool isMovingObstacles = false;
    static public bool isBirdFalling = false;
    static public bool isSpawingObstacle = false;

    //if set below variables to true, then set it to false when signalled
    static public bool isResetBirdPosition = false;
    static public bool isSpawnNewObstacle = false;

    // if set these variables below to true, it will affect the state of the game, and it will be set to true in the StateManager script
    static public bool isChangeStateFromWaitingToPlaying = false;
    static public bool isChangeStateFromPlayingToDead = false;
    static public bool isChangeStateFromDeadToWaiting = false;

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

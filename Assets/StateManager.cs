using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public enum GameState
    {
        Waiting,
        Playing,
        Dead
    }

    public void StartState( GameState state)
    {
        switch (state)
        {
            case GameState.Waiting:
                StartWaitingState();
                break;
            case GameState.Playing:
                StartPlayingState();
                break;
            case GameState.Dead:
                StartDeadState();
                break;
        }
    }

    void StartWaitingState()
    {
        GameConfig.currentGameState = GameState.Waiting;
        GameConfig.isMovingGround = true;
        GameConfig.isMovingObstacles = false;
        GameConfig.isSpawingObstacle = false;
        GameConfig.isBirdFalling = false;
        // Debug.Log("Waiting");
        // //call the gameconfig.logallinfo method
        // GameConfig.LogAllInfo();
    }
    void StartPlayingState()
    {
        GameConfig.currentGameState = GameState.Playing;
        GameConfig.isMovingGround = true;
        GameConfig.isMovingObstacles = true;
        GameConfig.isSpawingObstacle = true;
        GameConfig.isBirdFalling = true;
    }
    void StartDeadState()
    {
        GameConfig.currentGameState = GameState.Dead;
        GameConfig.isMovingGround = false;
        GameConfig.isMovingObstacles = false;
        GameConfig.isSpawingObstacle = false;
        GameConfig.isBirdFalling = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartState(GameState.Waiting);
    }
}

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

        //log the current state
        // Debug.Log("Current state: " + state);
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

        // Debug.Log("Playing");
    }
    void StartDeadState()
    {
        GameConfig.currentGameState = GameState.Dead;
        GameConfig.isMovingGround = false;
        GameConfig.isMovingObstacles = false;
        GameConfig.isSpawingObstacle = false;
        GameConfig.isBirdFalling = true;

        // Debug.Log("Dead");
    }

    void CheckEventToChangeState(){
        switch (GameConfig.currentGameState)
        {
            case StateManager.GameState.Waiting:
                {
                    //if the player press the space key or up key, then change the state to playing
                    if (GameConfig.isChangeStateFromWaitingToPlaying)
                    {
                        GameConfig.currentGameState = StateManager.GameState.Playing;
                        GameConfig.isChangeStateFromWaitingToPlaying = false;
                    }
                }
                break;
            case StateManager.GameState.Playing:
                {
                    if (GameConfig.isChangeStateFromPlayingToDead)
                    {
                        GameConfig.currentGameState = StateManager.GameState.Dead;
                        GameConfig.isChangeStateFromPlayingToDead = false;
                    }
                }
                break;
            case StateManager.GameState.Dead:
                {
                    if (GameConfig.isChangeStateFromDeadToWaiting)
                    {
                        GameConfig.currentGameState = StateManager.GameState.Dead;
                        GameConfig.isChangeStateFromDeadToWaiting = false;
                    }

                }
                break;
            default:
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartState(GameState.Waiting);
    }

    private void Update() {
        //Start the current state
        StartState(GameConfig.currentGameState);
        CheckEventToChangeState();
    }
}

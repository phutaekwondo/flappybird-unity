using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdStateManager : MonoBehaviour
{
    Vector2 startPosition;

    private void Start() {
        startPosition = transform.position;
    }
    private void Update() {
        //switch the currentGameState
        switch (GameConfig.currentGameState)
        {
            case StateManager.GameState.Waiting:
                StartWaitingState();
                break;
            case StateManager.GameState.Playing:
                StartPlayingState();
                break;
            case StateManager.GameState.Dead:
                StartDeadState();
                break;
            default:
                break;
        }
    }

    void ResetPosition(){
        transform.position = startPosition;
    }

    void StartWaitingState(){
        ResetPosition();
        //freeze the bird
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
    }

    void StartPlayingState(){
        //unfreeze y axis of the bird
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
    }

    void StartDeadState(){
        //free movement of the bird
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
    }
}

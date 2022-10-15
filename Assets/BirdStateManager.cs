using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdStateManager : MonoBehaviour
{
    Vector2 startPosition;

    //declare the start rotation of z axis
    Quaternion startRotation;

    private void Start() {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }
    private void Update() {
        StartTheCurrentState();

        if(GameConfig.isResetBirdPosition)
        {
            ResetPosition();
            GameConfig.isResetBirdPosition = false;
        }
    }

    void StartTheCurrentState()
    {
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
        transform.rotation = startRotation;
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

    //if collision
    private void OnCollisionEnter2D(Collision2D collision) {
        //if the bird collides with the ground or the obstacle
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Obstacle")
        {
            //if current state is playing
            if (GameConfig.currentGameState == StateManager.GameState.Playing)
            {
                //change the state to dead
                GameConfig.isChangeStateFromPlayingToDead = true;
            }
        }
    }
}

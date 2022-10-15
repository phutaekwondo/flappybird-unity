using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    //make the bird jump when the space key or the up key is pressed

    [SerializeField] private float jumpForce = 10f;
    public Rigidbody2D rb;

    private void Start() {
        //get the rigidbody component
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Debug.Log("Jump");

            // if the current state is Waiting, then change the state to Playing
            if (GameConfig.currentGameState == StateManager.GameState.Waiting)
            {
                GameConfig.isChangeStateFromWaitingToPlaying = true;
            }

            //ig the current state is dead, then change the state to Waiting
            if (GameConfig.currentGameState == StateManager.GameState.Dead)
            {
                GameConfig.isChangeStateFromDeadToWaiting = true;
            }

            Jump();
        }
    }

    public void Jump()
    {
            rb.velocity = Vector2.up * jumpForce;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//import GameConfig

public class RunGround : MonoBehaviour
{
    private float speed = 1;

    Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        //set speed to GameConfig.Speed
        speed = GameConfig.Speed;

        startPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameConfig.isMovingGround)
        {
            Vector2 currentPosition = transform.position;
            currentPosition.x -= speed * Time.deltaTime;

            transform.position = currentPosition;
        }
    }


    // private void OnTriggerEnter2D(Collider2D other) {
        // if ( other.CompareTag( "Finish")){
            // ResetPosition();
        // }
    // }

    private void OnCollisionEnter2D(Collision2D other) {
        //if collides with object has layer "Imagination" the reset the position
        if ( other.gameObject.layer == LayerMask.NameToLayer("Imagination")){
            ResetPosition();
        }
    }



    void ResetPosition(){
        // Debug.Log("Reset position");
        transform.position = startPosition;
    }
}

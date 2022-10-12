using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGround : MonoBehaviour
{
    [SerializeField] float speed = 1;
    Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 currentPosition = transform.position;
        currentPosition.x -= speed * Time.deltaTime;

        transform.position = currentPosition;
    }


    // private void OnTriggerEnter2D(Collider2D other) {
        // if ( other.CompareTag( "Finish")){
            // ResetPosition();
        // }
    // }

    private void OnCollisionEnter2D(Collision2D other) {
        if ( other.gameObject.CompareTag( "Finish")){
            ResetPosition();
        }
    }



    void ResetPosition(){
        // Debug.Log("Reset position");
        transform.position = startPosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheObstacleToLeft : MonoBehaviour
{
    //move the obstacle to left with a speed of 5
    public float speed;
    public GameObject Obstacles;

    void Start()
    {
        // set the speed to GameConfig.Speed
        speed = GameConfig.Speed;

        // set the Obstacles to the parent of this object
        Obstacles = transform.parent.gameObject;
    }

    void Update()
    {
        if (GameConfig.isMovingObstacles)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    //event when this collision a game object that has tag "NewObstacleWall"
    private void OnCollisionEnter2D(Collision2D other) {
        if ( other.gameObject.CompareTag( "NewObstacleWall")){
            // Debug.Log("Spawn new obstacle");

            //call a method from scripts of the Obstacles
            Obstacles.GetComponent<SpawnNewObstacle>().SpawnNewPairOfPipes();
        }
        if ( other.gameObject.CompareTag( "DestroyObstacleWall")){
            // Debug.Log("Destroy obstacle");
            Destroy(transform.gameObject);
        }
    }
}

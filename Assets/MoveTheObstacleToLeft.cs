using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheObstacleToLeft : MonoBehaviour
{
    //move the obstacle to left with a speed of 5

    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewObstacle : MonoBehaviour
{
    public GameObject PairOfPipes;

    public void SpawnNewPairOfPipes(){
        if (!GameConfig.isSpawingObstacle) return;

        // add a new Pair of Pipes as a child
        GameObject newPairOfPipes = Instantiate(PairOfPipes);
        newPairOfPipes.transform.SetParent( transform );

        //declare a float variable has a random value between -1 and 1
        float randomY = Random.Range(-1.7f, 1.7f);

        //set the position of new Pair of Pipes to zero
        Vector2 newPairPos = this.transform.position;
        newPairPos.y += randomY;
        newPairOfPipes.transform.position = newPairPos;
        
        //log the position of new Pair of Pipes
        // Debug.Log("New Pair of Pipes position: " + newPairOfPipes.transform.position);
    }

}

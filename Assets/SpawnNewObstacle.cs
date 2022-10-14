using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewObstacle : MonoBehaviour
{
    public GameObject PairOfPipes;

    public void SpawnNewPairOfPipes(){
        // add a new Pair of Pipes as a child
        GameObject newPairOfPipes = Instantiate(PairOfPipes);
        newPairOfPipes.transform.SetParent( transform );

        //set the position of new Pair of Pipes to zero
        newPairOfPipes.transform.position = this.transform.position;
        
        //log the position of new Pair of Pipes
        Debug.Log("New Pair of Pipes position: " + newPairOfPipes.transform.position);
    }

}

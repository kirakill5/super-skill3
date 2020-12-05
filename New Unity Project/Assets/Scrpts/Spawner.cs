using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float minY; 
    public float maxY ;
    public float distance ;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Obstacle")
        {
            //random Y position
            float obstacleY = Random.Range(minY, maxY);
            //choose position --> new obstacle
            Vector3 spawnPosition = new Vector3(transform . position . x + distance , obstacleY , 0);
            // Move Obstacle to SpawnPosition 
            col.gameObject.transform.position = spawnPosition;
        }
    }

}

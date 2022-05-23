using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
     public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
	}
	
    public void SpawnObject() {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(10, 11), Random.Range(-4,11), Random.Range(6.43f, 6.44f));
        Instantiate(spawnee, randomSpawnPosition, transform.rotation);
        if(stopSpawning) {
            CancelInvoke("SpawnObject");
        }
    }
}

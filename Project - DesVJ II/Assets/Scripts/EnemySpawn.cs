using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject enemy;

    [SerializeField] float timeFirstSpawn;
    [SerializeField] float timeBtwSpawns;

    void Awake()
    {
        InvokeRepeating("SpawnEnemy", timeFirstSpawn, timeBtwSpawns);
    }

	void SpawnEnemy ()
    {
		
	}
}

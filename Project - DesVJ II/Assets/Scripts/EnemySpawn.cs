using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject player;

    [SerializeField] float timeFirstSpawn;
    [SerializeField] float timeBtwSpawns;

    void OnEnable()
    {
        ManagerSpawner.Instance.ActiveSpawners.Add(this);
    }

    void OnDisable()
    {
        ManagerSpawner.Instance.ActiveSpawners.Remove(this);
    }

    void Awake()
    {
        InvokeRepeating("SpawnEnemy", timeFirstSpawn, timeBtwSpawns);
    }

	void SpawnEnemy ()
    {
        if (player)
        {
            var e = Instantiate(enemy);
            e.GetComponent<EnemyMovement>().Player = player.transform;
        }
	}
}

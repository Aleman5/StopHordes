using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSpawner : MonoBehaviour
{
    private static ManagerSpawner instance;

    public static ManagerSpawner Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<ManagerSpawner>();

            return instance;
        }
    }

    [SerializeField] List<EnemySpawn> activeSpawners;

    public List<EnemySpawn> ActiveSpawners
    {
        get
        {
            return activeSpawners;
        }
    }
}

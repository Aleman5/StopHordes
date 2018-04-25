using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // Para las escenas
using UnityEngine;

public class ManagerLevel : MonoBehaviour
{
    [SerializeField] string nextScene;

    void Update()
    {
        if(ManagerSpawner.Instance.ActiveSpawners.Count <= 0)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // Para las escenas
using UnityEngine;

public class ManagerLevel : MonoBehaviour
{
    private static ManagerLevel instance;

    public static ManagerLevel Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ManagerLevel>();
                if (instance == null)
                {
                    var go = new GameObject("ManagerLevel");
                    instance = go.AddComponent<ManagerLevel>();
                }
            }
            return instance;
        }
    }

    [SerializeField] Health health;

    [SerializeField] string winScene;
    [SerializeField] string loseScene;

    public void WinScene()
    {
        SceneManager.LoadScene(winScene);
    }
    public void LoseScene()
    {
        SceneManager.LoadScene(loseScene);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    [SerializeField] string nextScene;

    public void StartGame()
    {
        SceneManager.LoadScene(nextScene);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGame : MonoBehaviour
{
    [SerializeField] AudioSource backgroundMusic;

	void Start ()
    {
        backgroundMusic = backgroundMusic.GetComponent<AudioSource>();
        backgroundMusic.Play();
        Cursor.visible = false;
	}
}

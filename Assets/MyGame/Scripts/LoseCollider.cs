﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
    public GameObject loader;
    private SceneLoader sceneLoader;

    void Start ()
    {
        //Debug.Log(loader.GetComponents<SceneLoader>());
        sceneLoader = loader.GetComponent<SceneLoader>();
        
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        sceneLoader.LoadGameOver();
    }
}

﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OverContinue : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnClick()
    {
        SceneManager.LoadScene("game");
    }
}

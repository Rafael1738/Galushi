﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Start is called before the first frame update
    public void PlayGame() {
        Time.timeScale = 1f;
    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void QuitGame() {
        Debug.Log("Quit!!!");
        Application.Quit();
    }
}

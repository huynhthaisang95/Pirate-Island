﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayController3 : MonoBehaviour
{


    [SerializeField]
    private GameObject gameOverPanel,PausePanel;

    public static GamePlayController3 instance;
    void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public void ResumeButton()
    {
        SceneManager.LoadScene("Island3");
        gameOverPanel.gameObject.SetActive(false);
    }

    public void OptionsButton()
    {

        SceneManager.LoadScene("MainMenu");
        gameOverPanel.gameObject.SetActive(false);
    }

    public void BoatDiedShowPanel()
    {
        gameOverPanel.gameObject.SetActive(true);
    }


    public void PauseButton()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resumeButton()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitButton()
    {
        Application.Quit();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


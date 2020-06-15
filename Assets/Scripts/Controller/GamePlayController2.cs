using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayController2 : MonoBehaviour
{

    [SerializeField]
    private GameObject gameOverPanel,Pausepanel;

    public static GamePlayController2 instance;
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
        SceneManager.LoadScene("Island2");
        gameOverPanel.gameObject.SetActive(false);
    }

    public void OptionsButton()
    {

        SceneManager.LoadScene("MainMenu");
    }

    public void BoatDiedShowPanel()
    {
        gameOverPanel.gameObject.SetActive(true);
    }


    public void PauseButton()
    {
        Pausepanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resumeButton()
    {
        Pausepanel.SetActive(false);
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


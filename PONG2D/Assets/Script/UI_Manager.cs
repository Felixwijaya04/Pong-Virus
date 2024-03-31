using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject startMenu;
    public GameObject ball;
    public GameObject gameOver;

    public int score;
    private void Start()
    {
        startMenu.SetActive(true);
        ball.SetActive(false);
        Time.timeScale = 0f;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause();
        }
    }
    public void loadGame()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1.0f;
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Main Menu");
        
    }
    public void quitGame()
    {
        Application.Quit();
    }

    public void pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void resume()
    {
        pauseMenu.SetActive(false);
        startMenu.SetActive(false);
        ball.SetActive(true);
        Time.timeScale = 1f;
    }

    public void setScore(InputField value)
    {
        score = int.Parse(value.text);
        if(score <= 0)
        {
            startMenu.SetActive(false);
            EndTheGame();
        }
    }

    public void EndTheGame()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0f;
    }
}

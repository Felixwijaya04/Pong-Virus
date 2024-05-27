using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            loadGame();
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                loadMenu();
            }
            
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
}

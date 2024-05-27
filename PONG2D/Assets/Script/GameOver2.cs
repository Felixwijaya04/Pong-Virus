using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            loadGame2();
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                loadMenu();
            }

        }
    }

    public void loadGame2()
    {
        SceneManager.LoadScene("GameScene2P");
        Time.timeScale = 1.0f;
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Main Menu");

    }
}

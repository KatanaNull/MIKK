using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseGameMenu;
    private bool PauseGame = false;
    private bool _flagButtonPause = false;
    private bool _flagEscape;
    void Update()
    {
        _flagEscape = Input.GetKeyDown(KeyCode.Escape);

        if (_flagEscape == false && _flagButtonPause == true)
        {
            _flagButtonPause = false;
        }

        if (_flagEscape == true && _flagButtonPause == false)
        {
            _flagButtonPause = true;
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        PauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }
}

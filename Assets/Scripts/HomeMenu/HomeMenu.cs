using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeMenu : MonoBehaviour
{
    public GameObject GuideMenu;
    public GameObject HomeMenuu;
    public void PlayGame()
    {
        SceneManager.LoadScene("roomGG"); 
        //SceneManager.GetActiveScene().name;
    }

    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Scripts.Abstract;

public class InHomeMenu : MonoBehaviour
{
    public void ButtonInHomeMenu()
    {
        GameManager.ResetManager();
        MapManager.ResetManager();
        InventoryPlayer.ItemOfPlayer = null;
        LetterPlayers.LetterOfCount = null;
        InventoryPlayer.ItemOfPlayer = new List<Item>(6);
        LetterPlayers.LetterOfCount = new List<Letter>(0);
        SceneManager.LoadScene("HomeMenu", LoadSceneMode.Single);
    }
}

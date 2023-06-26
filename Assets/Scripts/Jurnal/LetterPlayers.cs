using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Abstract;

public static class LetterPlayers
{
    public static List<Letter> LetterOfCount = new List<Letter>(0);

    public static void AddNewLetter(Sprite imageLetter, string name, string[] Pepers)
    {
        Letter newLetter = new Letter(imageLetter, name, Pepers);

        Letter username = LetterOfCount.Find(x => x.name == newLetter.name);
        //Debug.Log(username);
        if (username == null)
            LetterOfCount.Add(newLetter);

    }

    public static bool LetterSearch(string name)
    {
        for (int i = 0; i < LetterOfCount.Count; i++)
        {
            if (LetterOfCount[i].name == name)
                return true;
        }
        return false;
    }

    public static void AddNewLetterTest(Sprite[] imageLetter, int index)
    {
        string[] Pepers = new string[4];
        Pepers[0] = index + " Страница1";
        Pepers[1] = index + " Страница2";
        Pepers[2] = index + " Страница3";
        Pepers[3] = index + " Страница4";
        for (int i = 0; i < 12; i++)
        {
            AddNewLetter(imageLetter[index], index + " Название" + i, Pepers); 
        }
    }
}

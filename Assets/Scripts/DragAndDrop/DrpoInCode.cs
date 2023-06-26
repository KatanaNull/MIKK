using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class DrpoInCode
{
    public static List<bool> examination = new List<bool>();

    public static bool examinationInCode(string background, string code)
    {
        Debug.Log(background == code);
        return background == code;
    }

    public static bool examinationCode(List<bool> mass)
    {
        Debug.Log(mass.Count);
        for (int i = 0; i < mass.Count; i++)//и здесь тоже
        {
            if (!mass[i])
                return false;
        }
        return true;
    }
}
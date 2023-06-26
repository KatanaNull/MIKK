using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitComputerButton : MonoBehaviour
{
    public GameObject computer;

    public void ExitComputer() 
    {
        computer.SetActive(false);
    }
}

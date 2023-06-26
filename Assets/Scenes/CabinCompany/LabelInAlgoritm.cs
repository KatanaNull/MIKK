using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelInAlgoritm : MonoBehaviour
{
    public GameObject dialogMenu;
    public GameObject algoritmMenu;


    public void OpenInAlgoritm() 
    {
        if (GameManager._JobInAlgoritm)
        {
            algoritmMenu.SetActive(true);
        }
        else
        {
            dialogMenu.SetActive(true);
        }
    }
}

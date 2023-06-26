using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingTheInterface : MonoBehaviour
{
    bool flagKeyI;
    bool flagInputKeyI = false;
    public GameObject Inventory;
    bool ActivInventory = false;

    bool flagKeyM;
    bool flagInputKeyM = false;
    public GameObject Map;
    bool ActivMap = false;

    bool flagKeyJ;
    bool flagInputKeyJ = false;
    public GameObject Jurnal;
    bool ActivJurnal = false;

    void Update()
    {
        flagKeyI = Input.GetKey(KeyCode.I) || Input.GetKey(KeyCode.Tab);
        flagKeyM = Input.GetKey(KeyCode.M);
        flagKeyJ = Input.GetKey(KeyCode.J);

        if (ActivJurnal || ActivMap || ActivInventory)
        {
            Time.timeScale = 0f;
        }
        else 
        {
            Time.timeScale = 1f;
        }
        //Инвентарь
        if (!flagKeyI && flagInputKeyI)
        {
            flagInputKeyI = false;
        }
        
        if (flagKeyI && !flagInputKeyI)
        {
            flagInputKeyI = true;
            ActivInventory = ActivMenu(ActivInventory, Inventory);
        }
        //карта
        if (!flagKeyM && flagInputKeyM)
        {
            flagInputKeyM = false;
        }

        if (flagKeyM && !flagInputKeyM)
        {
            flagInputKeyM = true;
            ActivMap = ActivMenu(ActivMap, Map);
        }
        //журнал
        if (!flagKeyJ && flagInputKeyJ)
        {
            flagInputKeyJ = false;
        }

        if (flagKeyJ && !flagInputKeyJ)
        {
            flagInputKeyJ = true;
            ActivJurnal = ActivMenu(ActivJurnal, Jurnal);
        }
    }

    private bool ActivMenu(bool flagUI, GameObject inrfaceUI) 
    {
        Inventory.SetActive(false);
        Map.SetActive(false);
        Jurnal.SetActive(false);
        ActivJurnal = false;
        ActivMap = false;
        ActivInventory = false;
        flagUI = !flagUI;
        inrfaceUI.SetActive(flagUI);
        return flagUI;
    }

    public void ActivJurnalButton()
    {
        Inventory.SetActive(false);
        Map.SetActive(false);
        Jurnal.SetActive(true);
        ActivJurnal = true;
        ActivMap = false;
        ActivInventory = false;
    }

    public void ActivMapButton()
    {
        Inventory.SetActive(false);
        Map.SetActive(true);
        Jurnal.SetActive(false);
        ActivJurnal = false;
        ActivMap = true;
        ActivInventory = false;
    }

    public void ActivInventoryButton()
    {
        Inventory.SetActive(true);
        Map.SetActive(false);
        Jurnal.SetActive(false);
        ActivJurnal = false;
        ActivMap = false;
        ActivInventory = true;
    }
}

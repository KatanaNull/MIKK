using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerInComputer : MonoBehaviour
{
    public GameObject dialogBox;
    public GameObject debugMenu;
    public GameObject computerMenu;
    public string dialog;

    private class textInDialogBox
    {
        public Text textInDialog { get; private set; }

        public textInDialogBox(Transform model)
        {
            textInDialog = model.Find("TextDialog").GetComponent<Text>(); ;
        }
    }

    private bool _flagButtonUse = false;
    private bool _flagButton;

    private void OnTriggerStay(Collider other) 
    {
        //Debug.Log(other.tag);
        _flagButton = Input.GetKey(KeyCode.E);
        if (_flagButton && !_flagButtonUse)
        {
            if (GameManager._JobComputerInRoomGG)
            {
                computerMenu.SetActive(true);
            }
            else if (InventoryPlayer.ItemSearch("Программатор"))
            {
                debugMenu.SetActive(true);
            }
            else
            {
                OpenInDialog(); 
            }
            _flagButtonUse = true;
        }

        if (!_flagButton && _flagButtonUse)
        {
            _flagButtonUse = false;
        }
    }
    
    private void OpenInDialog() 
    {
        textInDialogBox textInDialogBox = new textInDialogBox(dialogBox.transform);
        textInDialogBox.textInDialog.text = dialog;
        dialogBox.SetActive(true);
    }
}

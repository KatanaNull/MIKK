using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerComputerInRoom2 : MonoBehaviour
{
    public GameObject TrueDebuMenu;

    public GameObject dialogBox;
    public GameObject debugMenu;
    public GameObject computerMenu;
    public string dialog;

    private bool _flagButtonUse = false;
    private bool _flagButton;

    private class textInDialogBox
    {
        public Text textInDialog { get; private set; }

        public textInDialogBox(Transform model)
        {
            textInDialog = model.Find("TextDialog").GetComponent<Text>(); ;
        }
    }

    private void OnTriggerEnter()
    {
        GameManager.triggerComputerInRoom2(true);
        DrpoInCode.examination = null;
        DrpoInCode.examination = new List<bool>();
        for (int i = 0; i < 4; i++)
        {
            DrpoInCode.examination.Add(false);
        }
        //Debug.Log(DrpoInCode.examination.Count);
        //Debug.Log(DrpoInCode.examination);
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.tag);
        _flagButton = Input.GetKey(KeyCode.E);
        if (_flagButton && !_flagButtonUse)
        {
            if (GameManager._JobComputerInRoom2)
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

    private void OnTriggerExit()
    {
        GameManager.triggerComputerInRoom2(false);
    }

    public void TrueIdDebug()
    {
        GameManager.triggerJobComputerInRoom2(true);
        TrueDebuMenu.SetActive(false);
    }

    private void OpenInDialog()
    {
        textInDialogBox textInDialogBox = new textInDialogBox(dialogBox.transform);
        textInDialogBox.textInDialog.text = dialog;
        dialogBox.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerComputerInMedicalRoom : MonoBehaviour
{
    public GameObject TrueDebuMenu;
    //public int index;

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
        GameManager.triggerComputerInMedicalRoom(true);
        /*DrpoInCode.examination.Add(false);
        DrpoInCode.examination.Add(false);
        DrpoInCode.examination = null;
        DrpoInCode.examination = new List<bool>();*/
        //DrpoInCode.examination.Add(false);
        DrpoInCode.examination = null;
        DrpoInCode.examination = new List<bool>();
        for (int i = 0; i < 3; i++)
        {
            DrpoInCode.examination.Add(false);
        }
        //Debug.Log(DrpoInCode.examination.Count);
        //Debug.Log(DrpoInCode.examination);
    }

    private void OnTriggerExit()
    {
        GameManager.triggerComputerInMedicalRoom(false);
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.tag);
        _flagButton = Input.GetKey(KeyCode.E);
        if (_flagButton && !_flagButtonUse)
        {
            if (GameManager._JobComputerInMedicalRoom)
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

    public void TrueIdDebug()
    {
        GameManager.triggerJobComputerInMedicalRoom(true);
        TrueDebuMenu.SetActive(false);
    }

    private void OpenInDialog()
    {
        textInDialogBox textInDialogBox = new textInDialogBox(dialogBox.transform);
        textInDialogBox.textInDialog.text = dialog;
        dialogBox.SetActive(true);
    }
}

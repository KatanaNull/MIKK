using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerIn3DPrinter : MonoBehaviour
{
    public GameObject TrueDebuMenu;
    //public int index;

    public GameObject dialogBox;
    public GameObject debugMenu;
    public GameObject subjectItem;
    public string dialog;
    public string dialog1;
    public string dialog2;

    public Sprite itemSprite;
    public string name;
    public string description;
    public string fullDescription;

    private bool _flagButtonUse = false;
    private bool _flagButton;

    private class textInDialogBox
    {
        public Text textInDialog { get; private set; }

        public textInDialogBox(Transform model)
        {
            textInDialog = model.Find("TextDialog").GetComponent<Text>();
        }
    }

    private void OnTriggerEnter()
    {
        GameManager.triggerIn3DPrinter(true);
        /*DrpoInCode.examination.Add(false);
        DrpoInCode.examination.Add(false);
        DrpoInCode.examination = null;
        DrpoInCode.examination = new List<bool>();*/
        //DrpoInCode.examination.Add(false);
        DrpoInCode.examination = null;
        DrpoInCode.examination = new List<bool>();
        for (int i = 0; i < 4; i++)
        {
            DrpoInCode.examination.Add(false);
        }
        //Debug.Log(DrpoInCode.examination.Count);
        //Debug.Log(DrpoInCode.examination);
    }

    private void OnTriggerExit()
    {
        GameManager.triggerIn3DPrinter(false);
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.tag);
        _flagButton = Input.GetKey(KeyCode.E);
        if (_flagButton && !_flagButtonUse)
        {
            if (GameManager._JobIn3DPrinter)
            {
                if (GameManager._chip && !GameManager._DetalInDoor)
                {
                    subjectItem.SetActive(true);
                }
                else
                {
                    OpenInDialog(dialog1);
                }
            }
            else if (InventoryPlayer.ItemSearch("Программатор"))
            {
                if (LetterPlayers.LetterSearch("Документация для 3D принтера"))
                {
                    debugMenu.SetActive(true);
                }
                else 
                {
                    OpenInDialog(dialog2);
                }
            }
            else
            {
                OpenInDialog(dialog);
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
        GameManager.triggerJobIn3DPrinter(true);
        TrueDebuMenu.SetActive(false);
    }

    private void OpenInDialog(string dialog)
    {
        textInDialogBox textInDialogBox = new textInDialogBox(dialogBox.transform);
        textInDialogBox.textInDialog.text = dialog;
        dialogBox.SetActive(true);
    }
}

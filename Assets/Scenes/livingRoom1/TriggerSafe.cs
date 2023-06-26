using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSafe : MonoBehaviour
{
    public GameObject TrueDebuMenu;
    //public int index;

    public GameObject dialogBox;
    public GameObject debugMenu;
    public GameObject subjectItem;
    public string dialog;
    public string dialog1;
    public string dialog2;
    public string dialog3;

    public Transform passwordUser;
    public GameObject passwordUserObj;

    public Sprite itemSprite;
    public string name;
    public string description;
    public string fullDescription;

    private bool _flagButtonUse = false;
    private bool _flagButton;
    private string _pasword = "45100";

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
        GameManager.triggerInSafe(true);
        /*DrpoInCode.examination.Add(false);
        DrpoInCode.examination.Add(false);
        DrpoInCode.examination = null;
        DrpoInCode.examination = new List<bool>();*/
        //DrpoInCode.examination.Add(false);
        DrpoInCode.examination = null;
        DrpoInCode.examination = new List<bool>();
        for (int i = 0; i < 7; i++)
        {
            DrpoInCode.examination.Add(false);
        }
        //Debug.Log(DrpoInCode.examination.Count);
        //Debug.Log(DrpoInCode.examination);
    }

    private void OnTriggerExit()
    {
        GameManager.triggerInSafe(false);
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.tag);
        _flagButton = Input.GetKey(KeyCode.E);
        if (_flagButton && !_flagButtonUse)
        {
            if (GameManager._JobInSafe)
            {
                if (!GameManager._keyKart)
                {
                    passwordUserObj.SetActive(true);
                }
                else
                {
                    OpenInDialog(dialog1);
                }
            }
            else if (InventoryPlayer.ItemSearch("Программатор"))
            {
                if (LetterPlayers.LetterSearch("Документация для электронного сейфа"))
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
        GameManager.triggerJobInSafe(true);
        TrueDebuMenu.SetActive(false);
    }

    private void OpenInDialog(string dialog)
    {
        textInDialogBox textInDialogBox = new textInDialogBox(dialogBox.transform);
        textInDialogBox.textInDialog.text = dialog;
        dialogBox.SetActive(true);
    }

    public void ExamPassword(Transform model) 
    {
        string _paswordUser = model.Find("InputField (Legacy)").GetComponent<InputField>().text;
        if (_paswordUser == _pasword)
        {
            subjectItem.SetActive(true);
            passwordUserObj.SetActive(false);
        }
        else 
        {
            OpenInDialog(dialog3);
        }
    }
}

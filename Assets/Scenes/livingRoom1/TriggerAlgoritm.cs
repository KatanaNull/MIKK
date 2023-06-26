using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerAlgoritm : MonoBehaviour
{
    public GameObject debugMenu;
    public GameObject computer;
    public GameObject dialogMenu;
    public GameObject dialogBox;
    public GameObject TrueDebuMenu;
    public string dialog;

    private class textInDialogBox
    {
        public Text textInDialog { get; private set; }

        public textInDialogBox(Transform model)
        {
            textInDialog = model.Find("TextDialog").GetComponent<Text>(); ;
        }
    }

    public void ActivInDebugMenu()
    {
        if (LetterPlayers.LetterSearch("Работа шифра"))
        {
            debugMenu.SetActive(true);
            computer.SetActive(false);
            dialogMenu.SetActive(false);
            DrpoInCode.examination = null;
            DrpoInCode.examination = new List<bool>();
            for (int i = 0; i < 5; i++)
            {
                DrpoInCode.examination.Add(false);
            }
        }
        else
        {
            OpenInDialog(dialog);
        }
    }

    private void OpenInDialog(string dialog)
    {
        textInDialogBox textInDialogBox = new textInDialogBox(dialogBox.transform);
        textInDialogBox.textInDialog.text = dialog;
        dialogBox.SetActive(true);
    }

    public void TrueIdDebug()
    {
        GameManager.triggerJobInAlgoritm(true);
        TrueDebuMenu.SetActive(false);
    }
}

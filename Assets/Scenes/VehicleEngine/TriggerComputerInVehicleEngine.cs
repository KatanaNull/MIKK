using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerComputerInVehicleEngine : MonoBehaviour
{
    public GameObject TrueDebuMenu;

    public GameObject dialogBox;
    public GameObject debugMenu;
    public GameObject computerMenu;
    public string dialog;
    public string dialog1;

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

    private void Update()
    {
        if (GameManager._JobComputerInVegicleEngine)
        {
            SceneManager.LoadScene("Final", LoadSceneMode.Single);
        }
    }

    private void OnTriggerEnter()
    {
        GameManager.triggerComputerInVegicleEngine(true);
        DrpoInCode.examination = null;
        DrpoInCode.examination = new List<bool>();
        DrpoInCode.examination.Add(true);
    }

    private void OnTriggerExit()
    {
        GameManager.triggerComputerInVegicleEngine(false);
    }

    private void OnTriggerStay(Collider other)
    {
        _flagButton = Input.GetKey(KeyCode.E);
        if (_flagButton && !_flagButtonUse)
        {
            if (InventoryPlayer.ItemSearch("Программатор"))
            {
                if (LetterPlayers.LetterSearch("Работа основного двигателя корабля"))
                {
                    debugMenu.SetActive(true);
                }
                else
                {
                    OpenInDialog(dialog1);
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
        GameManager.triggerJobComputerInVegicleEngine(true);
        TrueDebuMenu.SetActive(false);
    }

    private void OpenInDialog(string dialog)
    {
        textInDialogBox textInDialogBox = new textInDialogBox(dialogBox.transform);
        textInDialogBox.textInDialog.text = dialog;
        dialogBox.SetActive(true);
    }
}

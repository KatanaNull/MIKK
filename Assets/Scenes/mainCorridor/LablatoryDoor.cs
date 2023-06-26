using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LablatoryDoor : MonoBehaviour
{
    public GameObject panelDoor;
    public RectTransform panelDoorTrans;
    public GameObject dialogBox;
    public string dialog;
    public string dialog1;

    private bool _flagPressButton = false;
    private bool _flagButton = false;
    private string _passwordDoor = "39168";


    private class textInDialogBox
    {
        public Text textInDialog { get; private set; }

        public textInDialogBox(Transform model)
        {
            textInDialog = model.Find("TextDialog").GetComponent<Text>(); ;
        }
    }

    private void OnTriggerStay()
    {
        _flagButton = Input.GetKey(KeyCode.E);

        if (_flagButton && !_flagPressButton)
        {
            if (GameManager._OpenInDoorLaboratory)
            {
                MapManager.MainCorridor = new Color(1, 1, 1);
                MapManager.Labolatory = new Color(1, 0.392f, 0.392f);
                SceneManager.LoadScene("laboratory", LoadSceneMode.Single);
            }
            else
            {
                panelDoor.SetActive(true);
                MapManager.DoorLabolatory = new Color(1, 4.8f, 0);
            }
            _flagPressButton = true;
        }

        if (!_flagButton && _flagPressButton)
        {
            _flagPressButton = false;
        }
    }

    public void ExaminationPassword()
    {
        if (panelDoorTrans.Find("InputField (Legacy)").GetComponent<InputField>().text == _passwordDoor)
        {
            GameManager.triggerInDoorLaboratory(true);
            Close();
            OpenInDialog(dialog1);
            MapManager.DoorLabolatory = new Color(0, 0.22f, 1);
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

    public void Close()
    {
        panelDoor.SetActive(false);
    }
}

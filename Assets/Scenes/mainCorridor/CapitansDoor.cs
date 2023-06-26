using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CapitansDoor : MonoBehaviour
{
    public GameObject panelDoor;
    public RectTransform panelDoorTrans;
    public GameObject dialogBox;
    public string dialog;
    public string dialog1;

    private bool _flagPressButton = false;
    private bool _flagButton = false;
    private string _passwordDoor = "74901";


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
            if (GameManager._OpenInDoorCapitansRoom)
            {
                MapManager.MainCorridor = new Color(1, 1, 1);
                MapManager.CapitansRoom = new Color(1, 0.392f, 0.392f);
                SceneManager.LoadScene("capitansRoom", LoadSceneMode.Single);
            }
            else
            {
                panelDoor.SetActive(true);
                MapManager.DoorCapitansRoom = new Color(1, 4.8f, 0);
            }
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
            GameManager.triggerInDoorCapitansRoom(true);
            Close();
            OpenInDialog(dialog1);
            MapManager.DoorCapitansRoom = new Color(0, 0.22f, 1);
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

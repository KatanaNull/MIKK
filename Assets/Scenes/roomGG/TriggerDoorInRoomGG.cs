using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Assets.Scripts.Map;

public class TriggerDoorInRoomGG : MonoBehaviour
{
    public GameObject panelDoor;
    public RectTransform panelDoorTrans;
    public GameObject dialogBox;
    public string dialog;
    public string dialog1;

    private bool _flagPressButton = false;
    private bool _flagButton = false;
    private string _passwordDoor = "38517";
    

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
            if (GameManager._OpenInDoorGGRoom)
            {
                if (MapManager.MainCorridor != new Color(1, 1, 1))
                {
                    MapManager.DoorLivingRoom1 = new Color(0.435f, 0.435f, 0.435f);
                    MapManager.DoorLivingRoom2 = new Color(0.435f, 0.435f, 0.435f);
                    MapManager.DoorMedicalRoom = new Color(0.435f, 0.435f, 0.435f);
                    MapManager.DoorSecurityRoom = new Color(0.435f, 0.435f, 0.435f);
                    MapManager.DoorCabinCompany = new Color(0.435f, 0.435f, 0.435f);
                    MapManager.DoorCapitansRoom = new Color(0.435f, 0.435f, 0.435f);
                    MapManager.DoorLabolatory = new Color(0.435f, 0.435f, 0.435f);
                    MapManager.DoorVehicleEngine = new Color(0.435f, 0.435f, 0.435f);
                    MapManager.LookDoor1 = new Color(0.435f, 0.435f, 0.435f);
                    MapManager.LookDoor2 = new Color(0.435f, 0.435f, 0.435f);
                    MapManager.LookDoor3 = new Color(0.435f, 0.435f, 0.435f);
                }
                MapManager.GGRoom = new Color(1, 1, 1);
                MapManager.MainCorridor = new Color(1, 0.392f, 0.392f);

                GameManager.StartPosition(new Vector3(-3.3f, 0.0250001f, 0.4f), 0, 0, 0);

                SceneManager.LoadScene("mainCorridor", LoadSceneMode.Single);

            }
            else
            {
                MapManager.DoorGGRoom = new Color(1, 0.48f, 0);
                //Map.UpdateMap();
                panelDoor.SetActive(true);
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
            MapManager.DoorGGRoom = new Color(0, 0.22f, 1);
            //Map.UpdateMap();

            GameManager.triggerInDoorRoomGG(true);
            Close();
            OpenInDialog(dialog1);
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

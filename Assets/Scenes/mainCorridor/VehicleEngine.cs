using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Assets.Scripts.Inventory;
using Assets.Scripts.Abstract;

public class VehicleEngine : MonoBehaviour
{
    public RectTransform prefab;
    public Image noActivPrefab;
    public RectTransform content;
    public RectTransform nextContent;
    public RectTransform prevContent;
    public Button backButton;
    public Button nextButton;
    public GameObject UIDescription;
    public GameObject UIInventory;

    public GameObject dialogBox;
    public string dialog;
    public string dialog1;

    private bool _flagPressButton = false;
    private bool _flagButton;


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
            if (GameManager._OpenInDoorVehicleEngine)
            {
                MapManager.MainCorridor = new Color(1, 1, 1);
                MapManager.VehicleEngine = new Color(1, 0.392f, 0.392f);
                SceneManager.LoadScene("VehicleEngine", LoadSceneMode.Single);
            }
            else
            {
                if (InventoryPlayer.ItemSearch("Деталь для двери"))
                {
                    Inventory inventory = new Inventory();
                    inventory.prefab = prefab;
                    inventory.noActivPrefab = noActivPrefab;
                    inventory.content = content;
                    inventory.nextContent = nextContent;
                    inventory.prevContent = prevContent;
                    inventory.backButton = backButton;
                    inventory.nextButton = nextButton;
                    inventory.UIDescription = UIDescription;
                    inventory.UIInventory = UIInventory;

                    inventory.removeOldItemInInventory("Деталь для двери");

                    GameManager.triggerInDoorVehicleEngine(true);

                    OpenInDialog(dialog1);
                    MapManager.DoorVehicleEngine = new Color(0, 0.22f, 1);
                }
                else
                {
                    OpenInDialog(dialog);
                    MapManager.DoorVehicleEngine = new Color(1, 4.8f, 0);
                }
            }
            _flagPressButton = true;
        }

        if (!_flagButton && _flagPressButton)
        {
            _flagPressButton = false;
        }
    }

    private void OpenInDialog(string dialog)
    {
        textInDialogBox textInDialogBox = new textInDialogBox(dialogBox.transform);
        textInDialogBox.textInDialog.text = dialog;
        dialogBox.SetActive(true);
    }
}

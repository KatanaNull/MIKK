using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Inventory;
using Assets.Scripts.Abstract;

public class TriggerDetalDoor : MonoBehaviour
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

    public GameObject dialogItem;
    private bool _flagButtonUse = false;
    private bool _flagButton;

    public Sprite[] spriteInventory;
    public string[] name;
    public string[] description;
    public string[] fullDescription;

    /*private void OnTriggerStay(Collider other)
    {
        _flagButton = Input.GetKey(KeyCode.E);

        if (_flagButton && !_flagButtonUse)
        {
            //Debug.Log("Âחÿעü ןנוהלוע");
            dialogItem.SetActive(true);
            _flagButtonUse = true;
        }

        if (!_flagButton && _flagButtonUse)
        {
            _flagButtonUse = false;
        }
        
    }*/

    public void DeactiveDialogItem()
    {
        dialogItem.SetActive(false);
    }

    public void DialogItemSubjectItem()
    {
        dialogItem.SetActive(false);
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

        GameManager.triggerDetalInDoor(true);

        inventory.addNewItemInInventory(spriteInventory[0], name[0], description[0], fullDescription[0]);

        inventory.removeOldItemInInventory(name[1]);

        inventory.OnReceivedModelsItem(InventoryPlayer.ItemOfPlayer, InventoryPlayer.activItem);
    }
}
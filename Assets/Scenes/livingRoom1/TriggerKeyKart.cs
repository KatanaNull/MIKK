using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Inventory;
using Assets.Scripts.Abstract;

public class TriggerKeyKart : MonoBehaviour
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
    //public GameObject ItemInScene;
    private bool _flagButtonUse = false;
    private bool _flagButton;

    public Sprite spriteInventory;
    public string name;
    public string description;
    public string fullDescription;

    public void KeyKartTrue ()
    {
        GameManager.triggerKeyKart(true);

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

        inventory.addNewItemInInventory(spriteInventory, name, description, fullDescription);
    }
}

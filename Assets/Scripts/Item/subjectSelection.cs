using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Inventory;
using Assets.Scripts.Jurnal;
using Assets.Scripts.Abstract;

public class subjectSelection : MonoBehaviour
{
    public GameObject active;

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
    public GameObject ItemInScene;
    private bool _flagButtonUse = false;
    private bool _flagButton;

    public GameObject doc;

    public Sprite spriteInventory;
    public string name;
    public string description;
    public string fullDescription;

    public RectTransform prefabJurnal;
    public RectTransform contentJurnal;
    public RectTransform document;
    public GameObject documentObj;
    public RectTransform jurnal;
    public GameObject jurnalObj;
    public RectTransform swichPunts;
    public GameObject swichPuntsObj;
    public RectTransform papersInDocument;
    public RectTransform contentInDocument;
    public RectTransform contentInDocumentObj;
    public Button backButtonJurnal;

    public Sprite spriteJurnal;
    public string nameLetter;
    public string[] pages = new string[2];

    private void Start()
    {
        //_flagButton = Input.GetKey(KeyCode.E);

        if (GameManager._programmer)
            Destroy(ItemInScene);
    }

    private void Update()
    {
        _flagButton = Input.GetKey(KeyCode.E);
    }

    private void OnTriggerStay(Collider other)
    {
        
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
    }

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

        Jurnal notJurnal = new Jurnal();

        notJurnal.prefab = prefabJurnal;
        notJurnal.content = contentJurnal;
        notJurnal.document = document;
        notJurnal.documentObj = documentObj;
        notJurnal.jurnal = jurnal;
        notJurnal.jurnalObj = jurnalObj;
        notJurnal.swichPunts = swichPunts;
        notJurnal.swichPuntsObj = swichPuntsObj;
        notJurnal.papersInDocument = papersInDocument;
        notJurnal.contentInDocument = contentInDocument;
        notJurnal.contentInDocumentObj = contentInDocumentObj;
        notJurnal.backButton = backButtonJurnal;

        active.SetActive(false);

        GameManager.triggerProgrammer(true);

        inventory.addNewItemInInventory(spriteInventory, name, description, fullDescription);

        Letter letter = new Letter(spriteJurnal, nameLetter, pages);

        notJurnal.addNewLetterInJurnal(letter);

        doc.SetActive(true);

        Destroy(ItemInScene);
    }
}

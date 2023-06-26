using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Inventory;
using Assets.Scripts.Abstract;
using Assets.Scripts.Jurnal;

public class Tester : MonoBehaviour
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

    //public GameObject dialogItem;
    //public GameObject ItemInScene;
    private bool _flagButtonUse = false;
    private bool _flagButton;

    public Sprite[] spriteInventory;
    public string[] name;
    public string[] description;
    public string[] fullDescription;

    /*public RectTransform prefabLetter;
    public RectTransform contentLetter;
    public RectTransform document;
    public GameObject documentObj;
    public RectTransform jurnal1;
    public GameObject jurnalObj;
    public RectTransform swichPunts;
    public GameObject swichPuntsObj;
    public RectTransform papersInDocument;
    public RectTransform contentInDocument;
    public Button backButton1;

    public Sprite letterSprite;
    public string nameLetter;
    public string[] pages;*/

    private class TextInPepersDocument
    {
        public Text[] textInPeper { get; private set; }
        public Image sptireLeter { get; private set; }

        public TextInPepersDocument(GameObject gameObject)
        {
            textInPeper = new Text[gameObject.transform.Find("ImageDoc").childCount];
            sptireLeter = gameObject.transform.Find("ImageDoc").GetComponent<Image>();
            for (int i = 0; i < gameObject.transform.Find("ImageDoc").childCount; i++)
            {
                Debug.Log(i);
                textInPeper[i] = gameObject.transform.Find("ImageDoc").GetChild(i).GetComponent<Text>();
            }
        }
    }

    private void Start()
    {
        GameManager.triggerChip(true);

        //dialogItem.SetActive(false);
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

        inventory.addNewItemInInventory(spriteInventory[0], name[0], description[0], fullDescription[0]);
        inventory.addNewItemInInventory(spriteInventory[1], name[1], description[1], fullDescription[1]);

        //Destroy(ItemInScene);
        //CreateNewLetters();
    }
    
    public void CreateNewLetters()
    {
        /*Sprite letterSprite;
        string name;
        string[] pages; = new string[gameObject.transform.Find("ImageDoc").childCount - 1];*/

        //TextInPepersDocument letter = new TextInPepersDocument(gameObject);

        //letterSprite = letter.sptireLeter.sprite;
        //nameLetter = letter.textInPeper[0].text;

        /*for (int i = 1; i < letter.textInPeper.Length; i++)
        {
            //Debug.Log(i - 1);
            pages[i - 1] = letter.textInPeper[i].text;
        }*/
        
        /*Letter letter1 = new Letter(letterSprite, nameLetter, pages);
        Jurnal jurnal = new Jurnal();
        jurnal.prefab = prefabLetter;
        jurnal.content = contentLetter;
        jurnal.document = document;
        jurnal.documentObj = documentObj;
        jurnal.jurnal = jurnal1;
        jurnal.jurnalObj = jurnalObj;
        jurnal.swichPunts = swichPunts;
        jurnal.swichPuntsObj = swichPuntsObj;
        jurnal.papersInDocument = papersInDocument;
        jurnal.contentInDocument = contentInDocument;
        jurnal.backButton = backButton;
        jurnal.addNewLetterInJurnal(letter1);
        //LetterPlayers.AddNewLetter(letterSprite, name, pages);*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Abstract;
using Assets.Scripts.Jurnal;

public class addNewEmail : MonoBehaviour
{
    //public GameObject thisLetter;
    public RectTransform prefab;
    public RectTransform content;
    public RectTransform document;
    public GameObject documentObj;
    public RectTransform jurnal1;
    public GameObject jurnalObj;
    public RectTransform swichPunts;
    public GameObject swichPuntsObj;
    public RectTransform papersInDocument;
    public RectTransform contentInDocument;
    public Button backButton;

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

    public void CreateNewLetters(GameObject gameObject)
    {
        Sprite letterSprite;
        string name;
        string[] pages = new string[gameObject.transform.Find("ImageDoc").childCount - 1];

        TextInPepersDocument letter = new TextInPepersDocument(gameObject);

        letterSprite = letter.sptireLeter.sprite;
        name = letter.textInPeper[0].text;

        for (int i = 1; i < letter.textInPeper.Length; i++)
        {
            //Debug.Log(i - 1);
            pages[i - 1] = letter.textInPeper[i].text;
        }

        Letter letter1 = new Letter(letterSprite, name, pages);
        Jurnal jurnal = new Jurnal();
        jurnal.prefab = prefab;
        jurnal.content = content;
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
        //LetterPlayers.AddNewLetter(letterSprite, name, pages);
    }
       

    //LetterPlayers.AddNewLetter(_spriteLetter, _nameLetter, _pagesLetter);

}
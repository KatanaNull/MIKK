using Assets.Scripts.Abstract;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Jurnal 
{
    public class Jurnal : MonoBehaviour
    {
        public RectTransform prefab;
        public RectTransform content;
        public RectTransform document;
        public GameObject documentObj;
        public RectTransform jurnal;
        public GameObject jurnalObj;
        public RectTransform swichPunts;
        public GameObject swichPuntsObj;
        public RectTransform papersInDocument;
        public RectTransform contentInDocument;
        public RectTransform contentInDocumentObj;
        public Button backButton;
        /*public Sprite testSprite;
        private bool _flagTestButton = false;
        private bool _testButton;*/


        public void Start()
        {
            OnReceivedModelsLetter(LetterPlayers.LetterOfCount);
        }

        private void Update()
        {
            /*_testButton = Input.GetKeyDown(KeyCode.G);

            if (_testButton && !_flagTestButton)
            {
                int index = UnityEngine.Random.Range(0, 3);
                int indexPages = UnityEngine.Random.Range(2, 5);
                string nameLetter = index + " Название" + index;
                string[] paperLetter = new string[indexPages];
                for (int i = 0; i < paperLetter.Length; i++)
                {
                    paperLetter[i] = index + " Страница " + i;
                }
                Letter newLetterTest = new Letter(testSprite, nameLetter, paperLetter);
                addNewLetterInJurnal(newLetterTest);
                _flagTestButton = true;
            }

            if (!_testButton && _flagTestButton)
            {
                _flagTestButton = false;
            }*/
        }

        void OnReceivedModelsLetter(List<Letter> models)
        {
            foreach (Transform child in content)
            {
                Destroy(child.gameObject);
            }

            foreach (var model in models)
            {
                var instanse = GameObject.Instantiate(prefab.gameObject) as GameObject;//Создаёт объекты
                instanse.transform.SetParent(content, false);
                InitializeLetterView(instanse, model);
            }
        }

        void InitializeLetterView(GameObject viewGameObject, Letter model)
        {
            TextLetterView view = new TextLetterView(viewGameObject.transform, viewGameObject);
            view.name.text = model.name;

            //Debug.Log(LetterPlayers.LetterOfCount.Count);

            view.theLetter.onClick.AddListener(
                () =>
                {
                    document.Find("ImageDoc").GetComponent<Image>().sprite = model.letterSprite;
                    documentObj.SetActive(true);
                    GenereitedInLetters(model);
                    jurnalObj.SetActive(false);
                    swichPuntsObj.SetActive(false);
                }
                );
        }

        public class TextLetterView
        {
            public Text name;
            public Button theLetter;

            public TextLetterView(Transform transform, GameObject gameObject)
            {
                name = transform.Find("NameLetter").GetComponent<Text>();
                theLetter = gameObject.GetComponent<Button>();
            }
        }

        public class TextInPepers
        {
            public Text textInPeper;

            public TextInPepers(GameObject gameObject)
            {
                textInPeper = gameObject.GetComponent<Text>();
                gameObject.GetComponent<Text>().enabled = true;
            }
        }

        public void GenereitedInLetters(Letter model)
        {
            foreach (Transform child in contentInDocument)
            {
                Destroy(child.gameObject);
            }

            var oneInstanse = GameObject.Instantiate(papersInDocument.gameObject) as GameObject;
            oneInstanse.transform.SetParent(contentInDocument, false);
            InitializePeperView(oneInstanse, model.name);
            oneInstanse.SetActive(true);
            backButton.interactable = false;

            for (int i = 0; i < model.pages.Length; i++)
            {
                var instanse = GameObject.Instantiate(papersInDocument.gameObject) as GameObject;
                instanse.transform.SetParent(contentInDocument, false);
                InitializePeperView(instanse, model.pages[i]);
                instanse.SetActive(false);
            }
        }

        void InitializePeperView(GameObject viewGameObject, string model)
        {
            TextInPepers view = new TextInPepers(viewGameObject);
            view.textInPeper.text = model;
        }

        public void addNewLetterInJurnal(Letter model)
        {
            var instanse = GameObject.Instantiate(prefab.gameObject) as GameObject;//Создаёт объекты
            instanse.transform.SetParent(content, false);
            //Debug.Log(instanse);
            LetterPlayers.AddNewLetter(model.letterSprite, model.name, model.pages);
            InitializeLetterView(instanse, model);
        }
    }
}
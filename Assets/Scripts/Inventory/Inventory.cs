using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Abstract;


namespace Assets.Scripts.Inventory
{
    public class Inventory : MonoBehaviour
    {
        public RectTransform prefab;
        public Image noActivPrefab;
        public RectTransform content;
        public RectTransform nextContent;
        public RectTransform prevContent;
        public Button backButton;
        public Button nextButton;
        private bool flagActivInMenuUse = false;
        private bool flagActivInMenuDescription = false;
        private bool flagActivInMenuInventory = true;
        public GameObject UIDescription;
        public GameObject UIInventory;
        public GameObject debugMenu;
        public Collider other;
        /*public Sprite[] testSprite = new Sprite[4];
        private bool _flagTestButton = false;
        private bool _testButton;*/

        public void Start()
        {
            backButton.interactable = false;
            OnReceivedModelsItem(InventoryPlayer.ItemOfPlayer, InventoryPlayer.activItem);
        }

        public void Update() 
        {
            if (InventoryPlayer.ItemOfPlayer.Count < 1 || InventoryPlayer.ItemOfPlayer.Count == InventoryPlayer.activItem + 1)
            {
                nextButton.interactable = false;
            }
            else
            {
                nextButton.interactable = true;
            }

            /*_testButton = Input.GetKeyDown(KeyCode.G);

            if (_testButton && !_flagTestButton)
            {
                int index = UnityEngine.Random.Range(0, testSprite.Length - 1);
                int Index1 = UnityEngine.Random.Range(2, 5);
                string nameItem = index + " Название" + Index1;
                string descriptionItem = index + " Описание" + Index1;
                string fullDescriptionItem = index + " Полное описание" + Index1;
                addNewItemInInventory(testSprite[index], nameItem, descriptionItem, fullDescriptionItem);
                _flagTestButton = true;
            }

            if (!_testButton && _flagTestButton)
            {
                _flagTestButton = false;
            }*/
        }



        public void OnReceivedModelsItem(List<Item> models, int idActivModel)
        {
            foreach (Transform child in content)
            {
                Destroy(child.gameObject);
            }
            foreach (Transform child in nextContent)
            {
                Destroy(child.gameObject);
            }
            foreach (Transform child in prevContent)
            {
                Destroy(child.gameObject);
            }
            for (int i = 0; i < models.Count; i++)
            {
                var instanse = GameObject.Instantiate(prefab.gameObject) as GameObject;//Создаёт объекты
                instanse.transform.SetParent(content, false);
                instanse.SetActive(i == idActivModel);
                InitializeIntemView(instanse, models[i]);


                var noPrevActivInstanse = GameObject.Instantiate(noActivPrefab.gameObject) as GameObject;
                noPrevActivInstanse.transform.SetParent(prevContent, false);
                noPrevActivInstanse.SetActive(i == idActivModel - 1);
                InitializeNoActivIntemView(noPrevActivInstanse, models[i]);

                var noNextActivInstanse = GameObject.Instantiate(noActivPrefab.gameObject) as GameObject;
                noNextActivInstanse.transform.SetParent(nextContent, false);
                noNextActivInstanse.SetActive(i == idActivModel + 1);
                InitializeNoActivIntemView(noNextActivInstanse, models[i]);

            }
        }

        public void InitializeNoActivIntemView(GameObject viewGameObject, Item model) 
        {
            TextNoActivItemView view = new TextNoActivItemView(viewGameObject.transform);
            view.imageItem.sprite = model.ItemSprite;
        }

        /*private void OnTriggerStay(Collider other)
        {
            //Debug.Log(other.name);
            if (other.name == "Player")
            {
                Debug.Log("Програматор");
                //debugMenu.SetActive(true);
            }

            if (other.tag == "Respawn")
            {
                Debug.Log("Компьютер");
                //debugMenu.SetActive(true);
            }
        }*/


        public void InitializeIntemView(GameObject viewGameObject, Item model)
        {
            TextItemView view = new TextItemView(viewGameObject.transform);
            view.name.text = model.Name;
            view.imageItem.sprite = model.ItemSprite;
            //Debug.Log(view.imageItem);
            view.description.text = model.description;

            view.use.onClick.AddListener(
                () =>
                {
                    /*if (GameManager._computerInRoomGG)
                    {

                    }
                    else 
                    {

                    }*/

                    //OnTriggerStay(other);

                    /*TextItemDescription itemDescription = new TextItemDescription(UIDescription.transform);
                    itemDescription.name.text = model.Name;
                    itemDescription.description.text = model.fullDescription;
                    itemDescription.itemImage.sprite = model.ItemSprite;
                    flagActivInMenuDescription = !flagActivInMenuDescription;
                    flagActivInMenuInventory = !flagActivInMenuInventory;
                    flagActivInMenuUse = !flagActivInMenuUse;
                    ActivInMenuUnventory(view.menuUse, flagActivInMenuUse);
                    ActivInMenuUnventory(UIDescription, flagActivInMenuDescription);
                    ActivInMenuUnventory(UIInventory, flagActivInMenuInventory);*/
                }
                );
            view.descriptionButton.onClick.AddListener(
                () =>
                {
                    TextItemDescription itemDescription = new TextItemDescription(UIDescription.transform);
                    itemDescription.name.text = model.Name;
                    itemDescription.description.text = model.fullDescription;
                    itemDescription.itemImage.sprite = model.ItemSprite;
                    flagActivInMenuDescription = !flagActivInMenuDescription;
                    flagActivInMenuInventory = !flagActivInMenuInventory;
                    flagActivInMenuUse = !flagActivInMenuUse;
                    ActivInMenuUnventory(view.menuUse, flagActivInMenuUse);
                    ActivInMenuUnventory(UIDescription, flagActivInMenuDescription);
                    ActivInMenuUnventory(UIInventory, flagActivInMenuInventory);

                }
                );
            view.imageItemButton.onClick.AddListener(
                () =>
                {
                    flagActivInMenuUse = !flagActivInMenuUse;
                    ActivInMenuUnventory(view.menuUse, flagActivInMenuUse);
                }
                );
        }

        public class TextNoActivItemView
        {
            public Image imageItem;

            public TextNoActivItemView(Transform transform)
            {
                this.imageItem = transform.GetComponent<Image>();
            }
        }

        public class TextItemView
        {
            public Text name;
            public Text description;
            //public Text fullDescription;
            public Image imageItem;
            public Button imageItemButton;
            public Button use;
            public Button descriptionButton;
            public GameObject menuUse;

            public TextItemView(Transform transform)
            {
                this.name = transform.Find("NameText").GetComponent<Text>();
                this.description = transform.Find("DescriptionText").GetComponent<Text>();
                this.imageItem = transform.Find("ItemImage").GetComponent<Image>();
                this.imageItemButton = transform.Find("ItemImage").GetComponent<Button>();
                this.use = transform.Find("MenuInterface").transform.Find("Use").GetComponent<Button>();
                this.descriptionButton = transform.Find("MenuInterface").transform.Find("Description").GetComponent<Button>();
                this.menuUse = transform.Find("MenuInterface").gameObject;

            }
        }

        public class TextItemDescription
        {
            public Text name;
            public Text description;
            public Image itemImage;

            public TextItemDescription(Transform transform)
            {
                this.name = transform.Find("TextName").GetComponent<Text>();
                this.description = transform.Find("TextDescription").GetComponent<Text>();
                this.itemImage = transform.Find("ImageItem").GetComponent<Image>();
            }
        }

        private void ActivInMenuUnventory(GameObject model, bool flag)
        {
            model.SetActive(flag);
        }

        public void DeactivInMenuDescription()
        {
            flagActivInMenuDescription = !flagActivInMenuDescription;
            flagActivInMenuInventory = !flagActivInMenuInventory;
            ActivInMenuUnventory(UIDescription, flagActivInMenuDescription);
            ActivInMenuUnventory(UIInventory, flagActivInMenuInventory);
        }

        public void addNewItemInInventory(Sprite ItemSprite, string Name, string description, string fullDescription) // Добовляем новый предмет
        {
            InventoryPlayer.AddNewItem(ItemSprite, Name,
                description, fullDescription);
            OnReceivedModelsItem(InventoryPlayer.ItemOfPlayer, InventoryPlayer.activItem);
        }


        public void removeOldItemInInventory(string Name) // Добовляем новый предмет
        {
            InventoryPlayer.RemoveOldItem(Name);
            OnReceivedModelsItem(InventoryPlayer.ItemOfPlayer, InventoryPlayer.activItem);
        }
    }
}
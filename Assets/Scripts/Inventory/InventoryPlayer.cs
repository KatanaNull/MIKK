using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Abstract;

public static class InventoryPlayer
{
    public static List<Item> ItemOfPlayer = new List<Item>(6);
    public static int activItem = 0;

    public static void AddNewItem(Sprite testImage, string name, string description, string fullDescription)
    {
        ItemOfPlayer.Add(new Item(testImage, name, description, fullDescription));
    }

    public static bool ItemSearch(string name)
    {
        for (int i = 0; i < ItemOfPlayer.Count; i++)
        {
            if (ItemOfPlayer[i].Name == name)
                return true;
        }
        return false;
    }

    public static void RemoveOldItem(string name)
    {
        Debug.Log("Удалить");
        for (int i = 0; i < ItemOfPlayer.Count; i++)
        {
            if (ItemOfPlayer[i].Name == name)
                ItemOfPlayer.RemoveAt(i);
        }
        /*Item item = new Item(testImage, name, description, fullDescription);
        ItemOfPlayer.Remove(item);*/
    }

    public static void AddNewItemTest(Sprite[] testImage, int[] index)
    {

        for (int i = 0; i < 6; i++)
        {
            AddNewItem(testImage[index[i]], "Название" + i, "Описание" + i, "Полное Описание" + i);
        }
    }

    public static bool checkingForThePresencItem(Sprite testImage, string name, string description, string fullDescription)
    {
        Item newItem = new Item(testImage, name, description, fullDescription);
        Item username = ItemOfPlayer.Find(x => x.Name == newItem.Name);
        return username == null;
    }
}
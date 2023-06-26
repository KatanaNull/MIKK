using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Abstract;

public class SelectorItem : MonoBehaviour
{
    [SerializeField] private Button _backButton;
    [SerializeField] private Button _nextButton;

    private int _selectedIndexItems;
    
    private void SelectItem(int index)
    {
        _backButton.interactable = (index > 0);
        _nextButton.interactable = (index < transform.childCount - 1);
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _selectedIndexItems);
        }
    }

    public void BackItem()
    {
        _selectedIndexItems--;
        InventoryPlayer.activItem--;
        SelectItem(_selectedIndexItems);
    }

    public void NextItem()
    {
        _selectedIndexItems++;
        InventoryPlayer.activItem++;
        SelectItem(_selectedIndexItems);
    }
}

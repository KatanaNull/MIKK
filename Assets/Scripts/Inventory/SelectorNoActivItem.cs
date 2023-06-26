using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SelectorNoActivItem : MonoBehaviour
{
    [SerializeField] private Button _backButton;
    [SerializeField] private Button _nextButton;
    public int indexStart;

    private int _selectedIndexItems;

    private void Awake()
    {
        _selectedIndexItems = indexStart;
        SelectItem(indexStart);
    }

    private void SelectItem(int index)
    {
        //Debug.Log("asfsad" + _selectedIndexItems);
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _selectedIndexItems);
        }
    }

    public void BackItem()
    {
        _selectedIndexItems--;
        SelectItem(_selectedIndexItems);
    }

    public void NextItem()
    {
        _selectedIndexItems++;
        SelectItem(_selectedIndexItems);
    }
}

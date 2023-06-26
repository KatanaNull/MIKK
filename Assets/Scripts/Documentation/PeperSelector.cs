using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeperSelector : MonoBehaviour
{
    [SerializeField] private Button _backButton;
    [SerializeField] private Button _nextButton;
    public GameObject theLetterObj;
    public GameObject swichMenu;
    public GameObject jurnal;

    private int _selectedIndexPapers;

    private void SelectPaper(int index)
    {
        _backButton.interactable = (index > 0);
        if (index >= transform.childCount - 1)
        {
            _nextButton.GetComponentInChildren<Text>().text = "Выход";
        }
        else
        {
            _nextButton.GetComponentInChildren<Text>().text = "Далее";
        }
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _selectedIndexPapers);
        }
    }

    public void BackPaper()
    {
        _selectedIndexPapers--;
        SelectPaper(_selectedIndexPapers);
    }

    public void NextPaper()
    {
        if (_nextButton.GetComponentInChildren<Text>().text == "Выход")
        {
            _nextButton.GetComponentInChildren<Text>().text = "Далее";
            _selectedIndexPapers = 0;
            theLetterObj.SetActive(false);
            if (swichMenu != null)
                swichMenu.SetActive(true);
            if (jurnal != null)
                jurnal.SetActive(true);
        }
        else
        {
            _selectedIndexPapers++;
            SelectPaper(_selectedIndexPapers);
        }
    }
}
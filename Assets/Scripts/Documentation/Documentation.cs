using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Documentation : MonoBehaviour
{
    public GameObject imageInActivCommputer;
    public GameObject ActivDocumentationCanvas;
    public Text Document;
    private bool ActivDocumentation = false;
    private int _numberPareOfDoc = 0;
    private bool _flagButton = false;

    public void OnTriggerEnter(Collider other) //вход в триггер
    {
        imageInActivCommputer.SetActive(true);
    }
    public void OnTriggerExit(Collider other) //выход из триггера
    {
        imageInActivCommputer.SetActive(false);
    }
    public void OnTriggerStay(Collider other) // нахождение в триггере
    {
        var flag = Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.Mouse0);


        if (_flagButton && !flag)
        {
            _flagButton = false;
        }

        if (flag && !_flagButton && !ActivDocumentation)
        {
            ActivDocumentation = ActivToDocumentationCanvas(ActivDocumentation);
            _flagButton = true;
        }


        if (ActivDocumentation && flag && !_flagButton)
        {
            NewNumberPare();
            _flagButton = true;
        }

        if (ActivDocumentation && Input.GetKey(KeyCode.Escape)) 
        {
            ActivDocumentation = ActivToDocumentationCanvas(ActivDocumentation);
        }

    }

    public bool ActivToDocumentationCanvas(bool flag)
    {
        if (flag)
        {
            ActivDocumentationCanvas.SetActive(false);
            imageInActivCommputer.SetActive(true);

            return false; 
        }
        else
        {
            ActivDocumentationCanvas.SetActive(true);
            imageInActivCommputer.SetActive(false);
            return true;
        }
    }

    public void NewNumberPare()
    {
        switch (_numberPareOfDoc)
        {
            case 0:
                Document.text = "Документация по 3д принтеру";
                _numberPareOfDoc++;
                break;
            case 1:
                Document.text = "Электронный сейф использует библиотеку elSafe. Сначала сейф “запоминает” пароль. Это делается с помощью функции changePassword(string password). Далее сейф ожидает введение пароля, с помощью функции enterЕheЗassword(string password). Если пароль трижды введен неверно, то сейф блокируется на 15 минут. Это делается с помощью функции BlockForWhile(int time). ";
                _numberPareOfDoc++;
                break;
            case 2:
                Document.text = "Если пароль введён верно, то сейф откроется. Это делается с помощью функции OpenSafe(). Функция CheckingTheSafeDoor() возвращает логическое значение и проверяет закрыт ли сейф или нет. Закрывает его с помощью функции CloseSafe().";
                _numberPareOfDoc++;
                break;
            case 3:
                _numberPareOfDoc = 0;
                GameMabager._statusActivSafe = true;
                ActivDocumentation = ActivToDocumentationCanvas(ActivDocumentation);
                break;
        }
    }

    public void OldNumberPare()
    {
        switch (_numberPareOfDoc)
        {
            case 0:
                ActivDocumentation = ActivToDocumentationCanvas(ActivDocumentation);
                _numberPareOfDoc = 0;
                break;
            case 1:
                Document.text = "Документация по 3д принтеру";
                _numberPareOfDoc--;
                break;
            case 2:
                Document.text = "Электронный сейф использует библиотеку elSafe. Сначала сейф “запоминает” пароль. Это делается с помощью функции changePassword(string password). Далее сейф ожидает введение пароля, с помощью функции enterЕheЗassword(string password). Если пароль трижды введен неверно, то сейф блокируется на 15 минут. Это делается с помощью функции BlockForWhile(int time). ";
                _numberPareOfDoc--;
                break;
            case 3:
                Document.text = "Если пароль введён верно, то сейф откроется. Это делается с помощью функции OpenSafe(). Функция CheckingTheSafeDoor() возвращает логическое значение и проверяет закрыт ли сейф или нет. Закрывает его с помощью функции CloseSafe().";
                _numberPareOfDoc--;
                break;
        }
    }
}
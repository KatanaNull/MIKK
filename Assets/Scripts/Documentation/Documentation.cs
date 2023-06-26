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

    public void OnTriggerEnter(Collider other) //���� � �������
    {
        imageInActivCommputer.SetActive(true);
    }
    public void OnTriggerExit(Collider other) //����� �� ��������
    {
        imageInActivCommputer.SetActive(false);
    }
    public void OnTriggerStay(Collider other) // ���������� � ��������
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
                Document.text = "������������ �� 3� ��������";
                _numberPareOfDoc++;
                break;
            case 1:
                Document.text = "����������� ���� ���������� ���������� elSafe. ������� ���� ����������� ������. ��� �������� � ������� ������� changePassword(string password). ����� ���� ������� �������� ������, � ������� ������� enter�he�assword(string password). ���� ������ ������ ������ �������, �� ���� ����������� �� 15 �����. ��� �������� � ������� ������� BlockForWhile(int time). ";
                _numberPareOfDoc++;
                break;
            case 2:
                Document.text = "���� ������ ����� �����, �� ���� ���������. ��� �������� � ������� ������� OpenSafe(). ������� CheckingTheSafeDoor() ���������� ���������� �������� � ��������� ������ �� ���� ��� ���. ��������� ��� � ������� ������� CloseSafe().";
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
                Document.text = "������������ �� 3� ��������";
                _numberPareOfDoc--;
                break;
            case 2:
                Document.text = "����������� ���� ���������� ���������� elSafe. ������� ���� ����������� ������. ��� �������� � ������� ������� changePassword(string password). ����� ���� ������� �������� ������, � ������� ������� enter�he�assword(string password). ���� ������ ������ ������ �������, �� ���� ����������� �� 15 �����. ��� �������� � ������� ������� BlockForWhile(int time). ";
                _numberPareOfDoc--;
                break;
            case 3:
                Document.text = "���� ������ ����� �����, �� ���� ���������. ��� �������� � ������� ������� OpenSafe(). ������� CheckingTheSafeDoor() ���������� ���������� �������� � ��������� ������ �� ���� ��� ���. ��������� ��� � ������� ������� CloseSafe().";
                _numberPareOfDoc--;
                break;
        }
    }
}
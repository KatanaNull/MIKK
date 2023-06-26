using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Assets.Scripts.DragAndDrop;

public class Examination : MonoBehaviour
{
    public GameObject CodeReviu;
    public GameObject ErrorMesseg;
    public GameObject OpenIsComplited;
    private bool _error = false;
    private bool _flagButton = false;
    private bool _flagInput;
    public string dialog;

    private class textInDialogBox
    {
        public Text textInDialog { get; private set; }

        public textInDialogBox(Transform model)
        {
            textInDialog = model.Find("TextDialog").GetComponent<Text>(); ;
        }
    }

    void Update()
    {
        _flagInput = Input.GetKey(KeyCode.Mouse0);
        if (_flagInput == false && _flagButton == true)
            _flagButton = false;

        if ((_flagInput == true && _flagButton == false) && _error)
        {
            Debug.Log($"Кнопка{_flagInput}, {_flagButton}, {_error}");
            _error = false;
            ErrorMesseg.SetActive(false);

        }

        if (Input.GetKey(KeyCode.Escape)) 
        {
            Close();
        }
    }

    public void Exam() 
    {
        var flag = DrpoInCode.examinationCode(DrpoInCode.examination);
        if (flag && !_error)
        {
            Debug.Log("True");
            OpenIsComplited.SetActive(true);
            Close();
        }
        else
        {
            Debug.Log("false");
            OpenInDialog();
            _error = true;
        }
    }

    public void Close()
    {
        CodeReviu.SetActive(false);
    }

    private void OpenInDialog()
    {
        textInDialogBox textInDialogBox = new textInDialogBox(ErrorMesseg.transform);
        textInDialogBox.textInDialog.text = dialog;
        ErrorMesseg.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManegerDialogBox : MonoBehaviour
{
    private bool _flagButtonUse = false;
    private bool _flagButton;

    public GameObject dialogBos;


    void Update()
    {
        _flagButton = Input.GetKey(KeyCode.Mouse0);

        if (_flagButton && !_flagButtonUse)
        {
            dialogBos.SetActive(false);
            _flagButtonUse = true;
        }

        if (!_flagButton && _flagButtonUse)
        {
            _flagButtonUse = false;
        }
    }
}

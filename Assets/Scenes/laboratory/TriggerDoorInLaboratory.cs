using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDoorInLaboratory : MonoBehaviour
{
    private bool _flagPressButton = false;
    private bool _flagButton = false;

    private void OnTriggerStay()
    {
        _flagButton = Input.GetKey(KeyCode.E);

        if (_flagButton && !_flagPressButton)
        {
            MapManager.Labolatory = new Color(1, 1, 1);
            MapManager.MainCorridor = new Color(1, 0.4f, 0.4f);
            GameManager.StartPosition(new Vector3(-5.5f, 0.0250001f, 0.4f), 0, 0, 0);
            SceneManager.LoadScene("mainCorridor", LoadSceneMode.Single);
        }

        if (!_flagButton && _flagPressButton)
        {
            _flagPressButton = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDoorInCapitanRoom : MonoBehaviour
{
    private bool _flagPressButton = false;
    private bool _flagButton = false;

    private void OnTriggerStay()
    {
        _flagButton = Input.GetKey(KeyCode.E);

        if (_flagButton && !_flagPressButton)
        {
            MapManager.CapitansRoom = new Color(1, 1, 1);
            MapManager.MainCorridor = new Color(1, 0.4f, 0.4f);
            GameManager.StartPosition(new Vector3(-6f, 0.0250001f, 0), 0, -90, 0);
            SceneManager.LoadScene("mainCorridor", LoadSceneMode.Single);
        }

        if (!_flagButton && _flagPressButton)
        {
            _flagPressButton = false;
        }
    }
}

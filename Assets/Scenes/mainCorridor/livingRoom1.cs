using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class livingRoom1 : MonoBehaviour
{
    private bool _flagPressButton = false;
    private bool _flagButton;

    private void OnTriggerStay()
    {
        _flagButton = Input.GetKey(KeyCode.E);

        if (_flagButton && !_flagPressButton)
        {
            MapManager.DoorLivingRoom1 = new Color(0, 0.22f, 1);
            MapManager.MainCorridor = new Color(1, 1, 1);
            MapManager.LivingRoom1 = new Color(1, 0.4f, 0.4f);
            SceneManager.LoadScene("livingRoom1", LoadSceneMode.Single);
            _flagPressButton = true;
        }

        if (!_flagButton && _flagPressButton)
        {
            _flagPressButton = false;
        }
    }
}

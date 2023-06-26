using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainCorridor : MonoBehaviour
{
    public Transform PlayerPosition;
    public void Start()
    {
        PlayerPosition = GetComponent<Transform>();
        switch (GameMabager._previousScene)
        {
            case "livingRoom1":
                PlayerPosition.Translate(2.7f, 0.2250001f, 0.718f);
                break;
            case "livingRoom2":
                PlayerPosition.Translate(-0.29f, 0.2250001f, -0.74f);
                break;
        }
        GameMabager._previousScene = SceneManager.GetActiveScene().name;
    }
}

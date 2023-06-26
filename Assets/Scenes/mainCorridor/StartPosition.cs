using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        player.transform.position = GameManager.PlayerPosition;
        player.transform.Rotate(GameManager.x, GameManager.y, GameManager.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivItem : MonoBehaviour
{
    public GameObject activItem;

    void OnTriggerEnter()
    {
        activItem.SetActive(true);
    }

    void OnTriggerExit()
    {
        activItem.SetActive(false);
    }
}

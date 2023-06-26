using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChip : MonoBehaviour
{
    public GameObject ThisItem;
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager._chip)
            Destroy(ThisItem);
    }

    // Update is called once per frame
    public void DestroyChip()
    {
        GameManager.triggerChip(true);
    }
}

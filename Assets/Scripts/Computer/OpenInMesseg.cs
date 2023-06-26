using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInMesseg : MonoBehaviour
{
    //public GameObject document;

    public void OpenInDocument(GameObject document) 
    {
        document.SetActive(true);
    }

    /*public void CloseInDocumentBackground()
    {
        backgroundDocument.SetActive(false);
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Algoritm : MonoBehaviour
{
    public GameObject objectInputField;
    public GameObject objectText;

    public void Encrypt()
    {
        string alphabet = "0123456789";
        string newAlphabet = "4567890123";
        string decoding = null;
        string combination = objectInputField.GetComponent<InputField>().text;
        for (int i = 0; i < combination.Length; i++)
        {
            for (int j = 0; j < newAlphabet.Length; j++)
            {
                if (combination[i] == alphabet[j])
                {
                    decoding = decoding + newAlphabet[j];
                    break;
                }
            }
        }
        objectText.GetComponent<Text>().text = decoding;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.Slot
{
    public class Slot : MonoBehaviour, IDropHandler
    {
        public GameObject _gameObject;
        public int _slotIndex;
        public void OnDrop(PointerEventData eventData)
        {
            var otherItemTransform = eventData.pointerDrag.transform;
            otherItemTransform.SetParent(transform);
            otherItemTransform.localPosition = Vector3.zero;
            string name = otherItemTransform.GetChild(0).GetComponent<Image>().name;
            //Debug.Log(name);
            string name1 = _gameObject.GetComponent<Image>().name;
            //Debug.Log(name1);
            Debug.Log(_slotIndex);
            DrpoInCode.examination[_slotIndex] = DrpoInCode.examinationInCode(name, name1); //Где-то ошибка
        }
    }
}
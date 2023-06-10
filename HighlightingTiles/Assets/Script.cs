using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UIElements;


public class Script : MonoBehaviour
{
    private HiglightableObject _lastHightlightedObject;

    void Update()
    {
        //инициализируем позицию мышки
        var mousePosition = Input.mousePosition;

        //инициализируем луч - передаем в камеру луч который будет бить в позицию
        // на которой будет находиться наша мышка
        var ray = Camera.main.ScreenPointToRay(mousePosition);

        //если на нашем объекте нет позиции мышки мы сбрасываем цвет
        if (_lastHightlightedObject != null)
        {
            _lastHightlightedObject.Reset();
        }


        //
        if (Physics.Raycast(ray, out var hitInfo))
        {
            var hightlightableObject = hitInfo.collider.gameObject.GetComponent<HiglightableObject>();


            if (hightlightableObject != null)
            {
                hightlightableObject.Highlight();
                //последнему подсвеченному объекту присваиваем ссылку на наш текущий объект 
                _lastHightlightedObject = hightlightableObject;
            }
        }
    }
}
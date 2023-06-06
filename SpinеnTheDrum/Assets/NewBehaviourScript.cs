using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform _myObject;

    [SerializeField] private float _rotationDelta = 2f;

    // Start is called before the first frame update
    void Start()
    {
        _myObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _myObject.Rotate(0, 0, _rotationDelta);
    }
}
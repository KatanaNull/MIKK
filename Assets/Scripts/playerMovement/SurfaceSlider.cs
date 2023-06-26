using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceSlider : MonoBehaviour
{
    private Vector3 _normal;

    public Vector3 Project(Vector3 forward)
    {
        return forward - Vector3.Dot(forward, _normal) * _normal;
    }

    private void Start()
    {

    }
    private bool _flag = true;
    private void OnCollisionEnter(Collision collision)
    {
        if (_flag)
        {
            _normal = collision.contacts[0].normal;
            _flag = false;
        }
    }
}

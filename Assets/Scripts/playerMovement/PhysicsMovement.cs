using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbogy;
    [SerializeField] private SurfaceSlider _surfaceSlider;
    /*[SerializeField] private*/public Animator _animator;
    [SerializeField] private float _spedd = 2f; 
    [SerializeField] private float _rotSpeed = 10f;

    public void Move(Vector3 direction)
    {
        _animator.SetFloat("speed", Vector3.ClampMagnitude(direction, 1).magnitude);
        if (direction.magnitude > Mathf.Abs(0.05f))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * _rotSpeed);


        Vector3 directionAlongSurface = _surfaceSlider.Project(direction.normalized);
        Vector3 offset = directionAlongSurface * (_spedd * Time.deltaTime);

        _rigidbogy.MovePosition(_rigidbogy.position + offset);
    }
}

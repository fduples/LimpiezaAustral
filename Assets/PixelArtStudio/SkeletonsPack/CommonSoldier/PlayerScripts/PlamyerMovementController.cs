using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlamyerMovementController : MonoBehaviour
{
    [Header("Asignables:")]
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private Rigidbody2D _rb; 

    [Header("editables:")]
    [SerializeField]
    private float _speed;

    private Vector2 _dir;

    private void FixedUpdate()
    {
        _dir = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
        {
            _dir.x = -1;
            _animator.SetInteger("Direction", 3);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _dir.x = 1;
            _animator.SetInteger("Direction", 2);
        }

        if (Input.GetKey(KeyCode.W))
        {
            _dir.y = 1;
            _animator.SetInteger("Direction", 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _dir.y = -1;
            _animator.SetInteger("Direction", 0);
        }

        _dir.Normalize();
        _animator.SetBool("IsMoving", _dir.magnitude > 0);

        _rb.velocity = _speed * _dir;
    }
}
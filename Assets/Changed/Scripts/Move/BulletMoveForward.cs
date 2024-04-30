using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveForward : MonoBehaviour, IMovableSimple
{

    [SerializeField] private float _moveSpeed;

    public float moveSpeed { get => _moveSpeed; set => _moveSpeed = value; }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        var translation = new Vector3(0, 0, 1) * _moveSpeed;
        transform.Translate(translation);
    }
}
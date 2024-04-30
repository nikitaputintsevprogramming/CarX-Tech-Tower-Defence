using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMove : MonoBehaviour, IMovableOnTarget
{
    [SerializeField] private Transform _moveTarget;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _reachDistance;

    public Transform moveTarget { get => _moveTarget; set => _moveTarget = value; }
    public float moveSpeed { get => _moveSpeed; set => _moveSpeed = value; }
    public float reachDistance { get => _reachDistance; set => _reachDistance = value; }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        if (_moveTarget == null)
            return;

        if (Vector3.Distance(transform.position, _moveTarget.transform.position) <= _reachDistance)
        {
            Destroy(gameObject);
            return;
        }

        var translation = _moveTarget.transform.position - transform.position;
        if (translation.magnitude > _moveSpeed)
        {
            translation = translation.normalized * _moveSpeed;
        }
        transform.Translate(translation);
    }
}

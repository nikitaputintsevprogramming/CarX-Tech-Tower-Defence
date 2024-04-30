using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveOnTarget : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 3f;
    public GameObject target;

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        var translation = target.transform.position - transform.position;
        if (translation.magnitude > _moveSpeed)
        {
            translation = translation.normalized * _moveSpeed;
        }
        transform.Translate(translation);
    }
}
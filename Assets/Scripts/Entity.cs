using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : ISpawnable, IMovable
{
    public Transform spawnPos { get; }
    public PrimitiveType primitiveType { get; }
    public float maxSpeed { get; }
    public Transform moveTarget { get; }
    public Vector3 currentPos { get; }
    public float reachDistance { get; }

    public Entity(PrimitiveType _primitiveType, Transform _spawnPos, Transform _moveTarget, float _entitySpeed, float _reachDistance)
    {
        maxSpeed = _entitySpeed;
        spawnPos = _spawnPos;
        primitiveType = _primitiveType;
        moveTarget = _moveTarget;
        reachDistance = _reachDistance;
    }

    public void Spawn()
    {
        Debug.Log("Спавнюсь в: " + spawnPos);
        var newEntity = GameObject.CreatePrimitive(primitiveType);
        var rb = newEntity.AddComponent<Rigidbody>();
        rb.useGravity = false;
        newEntity.transform.position = spawnPos.position;
        var monsterBeh = newEntity.AddComponent<Freak>();
        monsterBeh._spawnPlace = spawnPos;
        monsterBeh._targetMove = moveTarget;
        monsterBeh._entitySpeed = maxSpeed;
        monsterBeh._reachDistance = reachDistance;
    }

    public void Move(Transform _transform)
    {
        Debug.Log("Двигаюсь");
        if (moveTarget == null)
            return;

        var translation = moveTarget.position - _transform.position;
        if (translation.magnitude > maxSpeed)
        {
            translation = translation.normalized * maxSpeed;
        }
        _transform.Translate(translation);
    }
}

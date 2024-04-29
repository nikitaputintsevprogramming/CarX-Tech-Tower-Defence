using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalBulletFollower : MonoBehaviour, ISpawnable, IMovable
{
    [SerializeField] private string _entityName = "SimpleBullet";
    [SerializeField] private PrimitiveType _primitiveType;
    [SerializeField] private Transform _spawnPlace;
    [SerializeField] private Transform _moveTarget;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _reachDistance;

    public string nameOnSpawn { get => _entityName; set => _entityName = value; }
    public PrimitiveType primitiveType { get => _primitiveType; set => _primitiveType = value; }
    public Transform spawnPlace { get => _spawnPlace; set => _spawnPlace = value; }
    public Transform moveTarget { get => _moveTarget; set => _moveTarget = value; }
    public float moveSpeed { get => _moveSpeed; set => _moveSpeed = value; }
    public float reachDistance { get => _reachDistance; set => _reachDistance = value; }

    public void Initialize()
    {
        //”никальна€ логика дл€ сущности
        gameObject.name = _entityName;
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        var translation = transform.forward * _moveSpeed;
        transform.Translate(translation);
    }
}

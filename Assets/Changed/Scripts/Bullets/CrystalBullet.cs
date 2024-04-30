using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalBullet : MonoBehaviour, IShootable
{
    [SerializeField] private string _entityName = "CrystalBullet1";
    [SerializeField] private PrimitiveType _primitiveType;
    [SerializeField] private Transform _spawnPlace;
    [SerializeField] private float _rangeToTarget;

    public string nameOnSpawn { get => _entityName; set => _entityName = value; }
    public PrimitiveType primitiveType { get => _primitiveType; set => _primitiveType = value; }
    public Transform spawnPlace { get => _spawnPlace; set => _spawnPlace = value; }
    public float rangeToTarget { get => _rangeToTarget; set => _rangeToTarget = value; }

    public void Initialize()
    {
        //”никальна€ логика дл€ сущности
        gameObject.name = _entityName;

    }


}

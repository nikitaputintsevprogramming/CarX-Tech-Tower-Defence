using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogr : MonoBehaviour, ISpawnable
{
    [SerializeField] private string _entityName = "Ogr1";
    [SerializeField] private PrimitiveType _primitiveType;
    [SerializeField] private Transform _spawnPlace;
   
    public string nameOnSpawn { get => _entityName; set => _entityName = value; }
    public PrimitiveType primitiveType { get => _primitiveType; set => _primitiveType = value; }
    public Transform spawnPlace { get => _spawnPlace; set => _spawnPlace = value; }

    public void Initialize()
    {
        //”никальна€ логика дл€ сущности
        gameObject.name = _entityName;
    }
}

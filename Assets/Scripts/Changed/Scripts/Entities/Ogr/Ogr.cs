using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogr : MonoBehaviour, ISpawnable
{
    [SerializeField] private string entityName = "Ogr";
    public string EntityName { get => entityName; set => entityName = value; }
    private ParticleSystem particleSystem;

    public void Initialize()
    {
        //”никальна€ логика дл€ сущности
        gameObject.name = entityName;
    }
}

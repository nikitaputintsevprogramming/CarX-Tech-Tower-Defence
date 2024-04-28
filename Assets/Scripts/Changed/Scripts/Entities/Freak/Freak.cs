using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Freak : MonoBehaviour, ISpawnable
{
    [SerializeField] private string entityName = "Freak";
    public string EntityName { get => entityName; set => entityName = value; }
    private ParticleSystem particleSystem;

    public void Initialize()
    {
        //”никальна€ логика дл€ сущности
        gameObject.name = entityName;
        //particleSystem = GetComponentInChildren<ParticleSystem>();
        //particleSystem?.Stop();
        //particleSystem?.Play();
    }
}


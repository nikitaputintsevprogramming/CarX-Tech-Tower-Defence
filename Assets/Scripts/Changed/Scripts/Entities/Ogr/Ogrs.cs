using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogrs : Entities
{
    [SerializeField] private Ogr entityPrefab;

    public override ISpawnable GetEntity()
    {
        GameObject instance = Instantiate(entityPrefab.gameObject, entityPrefab.spawnPlace.position, Quaternion.identity);
        Ogr newEntity = instance.GetComponent<Ogr>();

        newEntity.Initialize();

        return newEntity;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freaks : Entities
{
    [SerializeField] private Freak entityPrefab;

    public override ISpawnable GetEntity()
    {
        GameObject instance = Instantiate(entityPrefab.gameObject, entityPrefab.spawnPlace.position, Quaternion.identity);
        Freak newEntity = instance.GetComponent<Freak>();

        newEntity.Initialize();

        return newEntity;
    }
}

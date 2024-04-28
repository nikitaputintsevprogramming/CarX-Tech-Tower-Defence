using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogrs : Entities
{
    [SerializeField] private Ogr entityPrefab;

    public override ISpawnable GetEntity(Vector3 position)
    {
        //Создаем префаб и получаем Entity компонент
        GameObject instance = Instantiate(entityPrefab.gameObject, position, Quaternion.identity);
        Ogr newEntity = instance.GetComponent<Ogr>();

        //Каждая сущность состоит из ее логики
        newEntity.Initialize();

        return newEntity;
    }
}
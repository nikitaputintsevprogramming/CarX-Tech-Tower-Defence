using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freaks : Entities
{
    [SerializeField] private Freak entityPrefab;

    public override ISpawnable GetEntity(Vector3 position)
    {
        //Создаем префаб и получаем Entity компонент
        GameObject instance = Instantiate(entityPrefab.gameObject, position, Quaternion.identity);
        Freak newEntity = instance.GetComponent<Freak>();

        //Каждая сущность состоит из ее логики
        newEntity.Initialize();

        return newEntity;
    }
}

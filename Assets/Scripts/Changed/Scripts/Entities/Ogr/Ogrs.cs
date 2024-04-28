using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogrs : Entities
{
    [SerializeField] private Ogr entityPrefab;

    public override ISpawnable GetEntity(Vector3 position)
    {
        //������� ������ � �������� Entity ���������
        GameObject instance = Instantiate(entityPrefab.gameObject, position, Quaternion.identity);
        Ogr newEntity = instance.GetComponent<Ogr>();

        //������ �������� ������� �� �� ������
        newEntity.Initialize();

        return newEntity;
    }
}
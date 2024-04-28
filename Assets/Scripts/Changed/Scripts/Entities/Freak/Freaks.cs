using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freaks : Entities
{
    [SerializeField] private Freak entityPrefab;

    public override ISpawnable GetEntity(Vector3 position)
    {
        //������� ������ � �������� Entity ���������
        GameObject instance = Instantiate(entityPrefab.gameObject, position, Quaternion.identity);
        Freak newEntity = instance.GetComponent<Freak>();

        //������ �������� ������� �� �� ������
        newEntity.Initialize();

        return newEntity;
    }
}

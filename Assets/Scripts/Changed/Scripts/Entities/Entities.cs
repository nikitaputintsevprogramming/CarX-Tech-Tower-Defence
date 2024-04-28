using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����� �� ����� ���������� ������� ��������� ����� �������������� (Entity1, Entity2...), ���
//�������, ��� ��� ����� ��������������� ���������� IEntity

//��� ����� ���������������� ���������� ����������� �����, ��� �������� Liskov
//������� ����� TowerDefence ����� ����� GetEntity, ������� ���������� ISpawnable. �� �����������,
//������� �� ����� ��������� ���������� TowerDefence ��������.
//�� ���������� ���� ���������� ����������, ������� ���������� ���� �������� ������ ���������


public abstract class Entities : MonoBehaviour
{
    //����� ���� ����� ������� ���. �������� GameObj � ���. �����
    public abstract ISpawnable GetEntity(Vector3 position);

    // shared method with all Models
    public string GetLog(ISpawnable spawnEntity)
    {
        string logMessage = "Entity: created " + spawnEntity.EntityName;
        return logMessage;
    }
}

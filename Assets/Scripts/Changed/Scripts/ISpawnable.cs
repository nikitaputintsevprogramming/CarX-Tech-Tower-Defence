using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//��� ��������� ������ ������ ������������� if switch - ISpawnable, TowerDefence

//������ ������ ������������ ������������� ������� ����� ������� � �����, ��� ����� �������� ���������
//���� ��������� ����������, ��� ������ ����� ���������� ������, � ���� ������ � ��� ���� ���� EntityName
//� ����� ������ �� ������� �������� �������� - ����������������
public interface ISpawnable
{
    public string EntityName { get; set; }
    public void Initialize();
}

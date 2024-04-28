using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Для поддержки логики вместо использования if switch - ISpawnable, TowerDefence

//Спавны должны принадлежать определенному шаблону своих методов и полей, для этого создадим интерфейс
//Этот интерфейс определяет, что общего между сущностями спавна, в этом случае у нас есть поле EntityName
//и любая логика на которой работает сущность - инициализируется
public interface ISpawnable
{
    public string EntityName { get; set; }
    public void Initialize();
}

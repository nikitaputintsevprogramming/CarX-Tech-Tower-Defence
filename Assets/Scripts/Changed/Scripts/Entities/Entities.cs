using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Затем мы можем определить сколько сущностей будет использоваться (Entity1, Entity2...), при
//условии, что они будут соответствовать интерфейсу IEntity

//Для общей функциональности используем абстрактный класс, для принципа Liskov
//Базовый класс TowerDefence имеет метод GetEntity, который возвращает ISpawnable. Он абстрактный,
//поэтому мы можем создавать экземпляры TowerDefence напрямую.
//Мы производим пару конкретных подклассов, которые фактически буду получать разных сущностей


public abstract class Entities : MonoBehaviour
{
    //Чтобы было проще создать экз. сборного GameObj в опр. месте
    public abstract ISpawnable GetEntity(Vector3 position);

    // shared method with all Models
    public string GetLog(ISpawnable spawnEntity)
    {
        string logMessage = "Entity: created " + spawnEntity.EntityName;
        return logMessage;
    }
}

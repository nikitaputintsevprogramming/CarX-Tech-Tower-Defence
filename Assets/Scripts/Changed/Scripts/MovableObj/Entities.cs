using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entities : MonoBehaviour
{
    public abstract ISpawnable GetEntity();

    public string GetLog(ISpawnable spawnEntity)
    {
        string logMessage = "Entity: created " + spawnEntity.entityName;
        return logMessage;
    }
}

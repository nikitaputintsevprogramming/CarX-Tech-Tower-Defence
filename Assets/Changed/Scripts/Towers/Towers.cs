using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Towers : MonoBehaviour
{
    public abstract IShootable GetShoot();

    public string GetLog(ISpawnable spawnEntity)
    {
        string logMessage = "Entity: created " + spawnEntity.nameOnSpawn;
        return logMessage;
    }
}

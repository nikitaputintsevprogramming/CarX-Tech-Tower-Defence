using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullets : MonoBehaviour
{ 
    public abstract ISpawnable Shoot();

    public string GetLog(ISpawnable spawnBullet)
    {
        string logMessage = "Entity: created " + spawnBullet.nameOnSpawn;
        return logMessage;
    }
}

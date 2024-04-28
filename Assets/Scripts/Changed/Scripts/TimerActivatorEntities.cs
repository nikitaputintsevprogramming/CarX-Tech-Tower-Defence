using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerActivatorEntities : MonoBehaviour
{
    [SerializeField] Entities[] entities;

    [SerializeField] float spawnEntityInterval;
    [SerializeField] float lastSpawnEntityTime;
    [SerializeField] float currentTime;

    private Entities entity;

    void Update()
    {
        TimerActivate();
    }

    private void TimerActivate()
    {
        currentTime = Time.timeSinceLevelLoad;

        if (currentTime > lastSpawnEntityTime + spawnEntityInterval)
        {
            entity = entities[Random.Range(0, entities.Length)];
            entity.GetEntity(new Vector3(-10, 0, 0));

            lastSpawnEntityTime = currentTime;
        }
    }
}

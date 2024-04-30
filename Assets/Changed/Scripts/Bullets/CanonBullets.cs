using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBullets : Towers
{
    [SerializeField] private CanonBullet bulletPrefab;

    [SerializeField] float shootInterval;
    [SerializeField] float lastShootTime;
    [SerializeField] float currentTime;

    public override IShootable GetShoot()
    {
        currentTime = Time.timeSinceLevelLoad;

        foreach (var entity in FindObjectsOfType<Hunted>())
        {
            if (currentTime > lastShootTime + shootInterval)
            {
                if (bulletPrefab == null || bulletPrefab.spawnPlace == null)
                    break;
                if (Vector3.Distance(bulletPrefab.spawnPlace.position, entity.transform.position) > bulletPrefab.rangeToTarget)
                {
                    break;
                }
                GameObject instance = Instantiate(bulletPrefab.gameObject, bulletPrefab.spawnPlace.position, Quaternion.identity);
                CanonBullet newEntity = instance.GetComponent<CanonBullet>();

                newEntity.Initialize();

                lastShootTime = currentTime;
                return newEntity;
            }
        }
        return null;
    }
}

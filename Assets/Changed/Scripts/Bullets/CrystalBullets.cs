using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalBullets : Towers
{
    [SerializeField] private CrystalBullet bulletPrefab;

    [SerializeField] private float shootInterval;
    private float lastShootTime;
    private float currentTime;

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
                CrystalBullet newEntity = instance.GetComponent<CrystalBullet>();

                bulletPrefab.GetComponent<BulletMoveOnTarget>().target = entity.gameObject;
                newEntity.Initialize();

                lastShootTime = currentTime;
                return newEntity;
            }
        }
        return null;
    }
}

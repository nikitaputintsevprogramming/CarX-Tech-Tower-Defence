using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalBullets : Bullets
{
    [SerializeField] private CrystalBulletFollower bulletPrefab;

    public override ISpawnable Shoot()
    {
        GameObject instance = Instantiate(bulletPrefab.gameObject, bulletPrefab.spawnPlace.position, Quaternion.identity);
        CrystalBulletFollower newBullet = instance.GetComponent<CrystalBulletFollower>();

        newBullet.Initialize();

        return newBullet;
    }
}

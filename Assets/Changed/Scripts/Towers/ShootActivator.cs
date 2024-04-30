using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootActivator : MonoBehaviour
{
    [SerializeField] Towers[] bullets;


    private Towers bullet;

    void Update()
    {
        ShootActivate();
    }

    private void ShootActivate()
    {
        foreach (var bulletCurrent in bullets)
        {
            bullet = bulletCurrent;
            bullet.GetShoot();
        }

    }
}
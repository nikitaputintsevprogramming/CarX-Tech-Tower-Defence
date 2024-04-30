using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootActivator : MonoBehaviour
{
    [SerializeField] Towers[] towers;


    private Towers tower;

    void Update()
    {
        ShootActivate();
    }

    private void ShootActivate()
    {
        foreach (var bulletCurrent in towers)
        {
            tower = bulletCurrent;
            tower.GetShoot();
        }

    }
}
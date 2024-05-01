using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBullets : Towers
{
    [SerializeField] private CanonBullet bulletPrefab;

    [SerializeField] float shootInterval;
    [SerializeField] float lastShootTime;
    [SerializeField] float currentTime;

    private bool ShootReady;
    public Transform curEntity;

    public override IShootable GetShoot()
    {
        foreach (var entity in FindObjectsOfType<Hunted>())
        {
            if (bulletPrefab == null || bulletPrefab.spawnPlace == null)
                break;

            if (Vector3.Distance(bulletPrefab.spawnPlace.position, entity.transform.position) > bulletPrefab.rangeToTarget)
            {
                break;
            }

            if (curEntity == null)
                curEntity = entity.transform;

            if (ShootReady)
            {
                GameObject instance = Instantiate(bulletPrefab.gameObject, bulletPrefab.spawnPlace.position, transform.rotation);
                CanonBullet newEntity = instance.GetComponent<CanonBullet>();

                newEntity.Initialize();

                lastShootTime = currentTime;
                return newEntity;
            }
        }
        return null;
    }

    private void Update()
    {
        TimerShoot();
        RotateOnTarget();
        SensorTarget();
    }

    private void TimerShoot()
    {
        if (currentTime > lastShootTime + shootInterval)
        {
            ShootReady = true;
        }
        else
        {
            ShootReady = false;
        }
        currentTime = Time.timeSinceLevelLoad;
    }

    private void RotateOnTarget()
    {
        if (curEntity == null)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, 10 * Time.deltaTime);
            return;
        }


        //print(speedCurEntity);
        var targetRotation = Quaternion.LookRotation(curEntity.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10 * Time.deltaTime);
    }

    private void Deflection()
    {

    }

    private Vector3 SensorTarget()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            //Debug.Log("Did Hit");
            return hit.point;
        }
        else
        {
            return Vector3.zero;
        }
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 0.3f, 0.3f, 0.3f);
        Gizmos.DrawSphere(GameObject.FindGameObjectWithTag("CanonShootPoint").transform.position, bulletPrefab.rangeToTarget);
    }
}
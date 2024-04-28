using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour, IDamageable
{
    public float startingHealth = 100f;
    public Vector3 Position
    {
        get
        {
            return transform.position;
        }
    }
     float m_CurrentHealth;

    void Start()
    {
        m_CurrentHealth = startingHealth;
    }
    public void Damage(float damage)
    {
        m_CurrentHealth -= damage;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freak : MonoBehaviour
{
    public PrimitiveType _primitiveType;
    public Transform _spawnPlace;
    public Transform _targetMove;
    public float _entitySpeed;
    public float _reachDistance;

    private void Start()
    {
        Entity freak = new Entity(_primitiveType, _spawnPlace, _targetMove, _entitySpeed, _reachDistance);
        freak.Spawn();
    }

    private void Update()
    {
        //freak.Move(transform);

        if (Vector3.Distance(transform.position, _targetMove.position) <= _reachDistance)
        {
            Destroy(transform.gameObject);
            return;
        }
    }
}

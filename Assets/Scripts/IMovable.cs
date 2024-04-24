using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IMovable 
{
    float maxSpeed { get; }
    Transform moveTarget { get; }
    Vector3 currentPos { get; }
    float reachDistance { get; }

    void Move(Transform _transform);
}

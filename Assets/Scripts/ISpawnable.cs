using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface ISpawnable
{
    Transform spawnPos { get; }
    PrimitiveType primitiveType { get; }

    void Spawn();
}


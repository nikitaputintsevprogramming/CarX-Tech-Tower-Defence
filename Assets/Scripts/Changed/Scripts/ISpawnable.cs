using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawnable
{
    public string entityName { get; set; }
    public PrimitiveType primitiveType { get; set; }
    public Transform spawnPlace { get; set; }
    public void Initialize();
}

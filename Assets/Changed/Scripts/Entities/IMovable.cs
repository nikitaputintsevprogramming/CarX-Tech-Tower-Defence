using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovableSimple
{
	public float moveSpeed { get; set; }
	public void Move();
}

public interface IMovableOnTarget : IMovableSimple
{
	public Transform moveTarget { get; set; }
	public float reachDistance { get; set; }	
}
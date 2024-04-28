using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable 
{
	public Transform moveTarget { get; set; }
	public float moveSpeed { get; set; }
	public float reachDistance { get; set; }

	public void Move();
}

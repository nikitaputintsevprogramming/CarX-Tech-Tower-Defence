using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public float m_interval = 3;
	public GameObject m_moveTarget;

	[SerializeField] private float m_lastSpawn = -1;

	[SerializeField] private float _theClockIsTicking;
	[SerializeField] private float _OnShitTheTimeIsReset = 0;
	[SerializeField] private float _timeForAlahAkbar;

	void Update () {
		//if (Time.time > m_lastSpawn + m_interval) {
		//	var newMonster = GameObject.CreatePrimitive (PrimitiveType.Capsule);
		//	var r = newMonster.AddComponent<Rigidbody> ();
		//	r.useGravity = false;
		//	newMonster.transform.position = transform.position;
		//	var monsterBeh = newMonster.AddComponent<Monster> ();
		//	monsterBeh.m_moveTarget = m_moveTarget;

		//	m_lastSpawn = Time.time;
		//}
	}

	private void SpawnTimer()
    {
		_theClockIsTicking = Time.timeSinceLevelLoad - _OnShitTheTimeIsReset;
		if (Input.GetMouseButtonDown(0))
		{
			Reset();
		}

		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);

			if (touch.phase == TouchPhase.Began)
			{
				Reset();
			}
		}

		if (_theClockIsTicking > _timeForAlahAkbar)
		{
			SceneManager.LoadScene(0);
		}
	}

	private void Reset()
	{
		_OnShitTheTimeIsReset += _theClockIsTicking;
		_theClockIsTicking = 0f;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SpawnTimer : MonoBehaviour
{
    [SerializeField] private float _theClockIsTicking;
    [SerializeField] private float _OnShitTheTimeIsReset = 0;

    [SerializeField] private float _timeForAlahAkbar;

    private void Update()
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
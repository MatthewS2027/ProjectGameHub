
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Hopefully this should lead to a clean Hit Stop Setup
// Call 'execHitStop' in weapon scripts and pass duration

public class HitStop : MonoBehaviour
{

    public static HitStop instance;
    private bool isHitStopping = false;

    private void Awake()
    {
        instance = this;
    }

    public void ExecHitStop(float duration)
    {
        if (!isHitStopping)
        {
            StartCoroutine(HitStopEnum(duration));
        }
    }

    private IEnumerator HitStopEnum(float duration)
    {
        isHitStopping = true;

        if (Time.timeScale == 1.0f)
        {
            Time.timeScale = 0.1f;
            yield return new WaitForSecondsRealtime(duration);
        }

        Time.timeScale = 1.0f;

        isHitStopping = false;

    }

}
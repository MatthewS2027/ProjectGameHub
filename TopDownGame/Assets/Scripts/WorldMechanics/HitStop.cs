
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Hopefully this should lead to a clean Hit Stop Setup
// Call 'execHitStop' in weapon scripts and pass duration

// Hopefully this should lead to a clean Hit Stop Setup
// Call 'execHitStop' in weapon scripts and pass duration

public class HitStop : MonoBehaviour
{

    public static HitStop instance;
    private bool isHitStopping = false;

    public bool IsHitStopping => isHitStopping;

    [SerializeField] private float baseCooldown = 1f;

    private void Awake()
    {
        instance = this;
    }

    public void ExecHitStop(float duration)
    {
        if (!isHitStopping)
        {
            Debug.Log("Hit Stop == True");
            StartCoroutine(HitStopEnum(duration));
        }
    }

    private IEnumerator HitStopEnum(float duration)
    {
        Debug.Log("Cooldown Started");
        isHitStopping = true;

        if (Time.timeScale == 1.0)
        {
            Time.timeScale = 0.05f;
            yield return new WaitForSecondsRealtime(duration);
        }

        Time.timeScale = 1.0f;


        yield return new WaitForSeconds(baseCooldown);

        isHitStopping = false;

        Debug.Log("Cooldown Ended");


    }

}

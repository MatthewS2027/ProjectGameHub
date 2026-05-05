using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStop : MonoBehaviour
{
    public static HitStop instance;

    private bool isHitStopping;

    private void Awake()
    {
        instance = this;
    }

    public void ScreenFreeze(float duration, float timeScale = 0f)
    {
        if (isHitStopping) return;
        StartCoroutine(DoHitStop(duration, timeScale));
    }

    private IEnumerator DoHitStop(float duration, float timeScale)
    {
        isHitStopping = true;

        float originalTimeScale = Time.timeScale;

        Time.timeScale = timeScale;
        yield return new WaitForSecondsRealtime(duration);
        Time.timeScale = originalTimeScale;

        isHitStopping = false;
        yield return new WaitForSeconds(0.1f);

        
    }

}

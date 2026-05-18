
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

	public void execHitStop(float duration)
	{
		if (!isHitStopping)
		{
			StartCoroutine(HitStopEnum(duration));
		}
	}

	private IEnumerator HitStopEnum(float duration)
	{
		isHitStopping = true;
	
		if (Time.timeScale == 1.0)
		{
			Time.timeScale = 0.7;
			yield return new WaitForSecondsRealtime(duration);
		}
		
		Time.timeScale = 1.0;
		
		isHitStopping = false;
	
	}

}

// Should implement player I-Frames when called. Pass duration float.
// If this does not work consistently, I will add a PlayerHealth method that
// allows for enabling/disabling player taking damage.

public class I_Frames : MonoBehaviour
{

	public static I_Frames instance;
	private bool IFramesActive { get; private set; }

	private void Awake()
	{
		instance = this;
	}

	public void execIFrames(float duration)
	{
		if (!IFramesActive)
		{
			StartCoroutine(IFrameEnum(duration));
		}
	}

	private IEnumerator IFrameEnum(float duration)
	{
		IFramesActive = true;

		yield return new WaitForSeconds(duration);

		IFramesActive = false;
	}
}
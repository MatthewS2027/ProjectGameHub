
// Shared configuration data
public class StatusEffectData : ScriptableObject
{

	public string effectName;

	public float duration;

	public float tickRate;

	public float magnitude;

	public GameObject vfxPrefab;

	public bool canStack;

	public int maxStacks;

}
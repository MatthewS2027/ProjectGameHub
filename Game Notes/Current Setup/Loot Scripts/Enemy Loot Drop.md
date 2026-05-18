
// Stores possible loot drops
// Creates prefab instance; Called from Enemy Health class
// handles loot drop logic
// For prototype this should be called from boss prefab

public class EnemyLootDrop : MonoBehaviour
{
	// Create LootEntry data container class
	/*
	[System.Serializable]
	public class LootEntry
	{
		public WeaponData weapon;    // This is a pointer to a Scriptable Object
		[Range(0f, 100f)];
		public float dropChance;
	}

	// List all possible drops for enemy; editable in inspector per instance
	[SerializeField] private LootEntry[] lootTable;


	// This will be called either from EnemyHealth.Die or from boss death logic
	public void LootDrop()
	{
		foreach (LootEntry entry in lootTable)
		{
			float roll = Random.Range(0f, 100f);

			if (roll <= entry.dropChance)
			{
				// Creates weapon prefab, at enemy position, with no rotation
				Instantiate(entry.weapon.pickupPrefab, transform.position, Quaternion.Identity);
			}
		}
	}

	*/

}
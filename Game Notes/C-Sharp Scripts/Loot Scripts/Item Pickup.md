
// Use Collider2D to detect Player pickup range
// Make sure OnTrigger is selected for item collider
// Give Item to Player
// Destroy this Game Object

public class ItemPickup : MonoBehaviour
{ 

	// Add reference WeaponData weaponData.

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			Inventory inventory = col.GetComponent<Inventory>();

			if (inventory != null)
			{
				bool added = inventory.AddWeapon(weaponData);

				if (added)
				{
					Destroy(gameObject);
				}
			}
		}
	}
}
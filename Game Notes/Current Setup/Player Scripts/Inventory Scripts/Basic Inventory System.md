
// 1. Store WeaponData references
// 2. Display them in UI slots
// 3. Allow adding items from pickups

#### Overview

Unity Editor Structure:
Canvas
- Inventory Panel
	- 30 Slot UI Objects

Scripts
	Inventory
	InventorySlotUI
	ItemPickup (Done)

#### CREATE INVENTORY UI:

Create Canvas:
- Right click in hierarchy, UI, Canvas
- Unity will create EventSystem

Create Inventory Panel
- Right click inside Canvas, UI, Panel, 'InventoryPanel'

Add Grid Layout Group
- Select InventoryPanel
- Add Grid Layout Group Component
- Config: Cell Size (64x64), Spacing (5x5), Constraint -> Fixed Column Count, Constraint Count -> 10
- This will create 10 cols. x 3 rows

### Create Slot UI Object

Inside InventoryPanel
- Right click, UI, Image
- Rename to InventorySlot
- Resize to 64 x 64
- May use dark/translucent sprite

#### Create Item Icon Child

Inside InventorySlot
- Right click, UI, Image
- Rename to ItemIcon, stretch to fill slot
- This will display weapon icons

#### Make Inventory Slot Prefab

- Drag Inventory Slot into prefab folder
- Delete all other inventory slots from hierarchy


--------------------------------------------------------------------------
## Inventory Script


public class Inventory : MonoBehaviour
{
	public List<WeaponData> weapons = new List<WeaponData>();  
  
	public int maxSlots = 30;  
  
	public bool AddWeapon(WeaponData weapon)  
	{  
		if (weapons.Count >= maxSlots)  
		{  
			Debug.Log("Inventory Full");  
			return false;  
		}  
  
		weapons.Add(weapon);  
  
		Debug.Log(weapon.weaponName + " added to inventory.");  
  
		return true;  
	}  
}





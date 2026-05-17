
public class InventorySlotUI : Monobehaviour
{
	[SerializeField] private Image itemIcon;  
  
	public void SetItem(WeaponData weapon)  
	{  
		if (weapon != null)  
		{  
			itemIcon.sprite = weapon.icon;  
			itemIcon.enabled = true;  
		}  
		else  
		{  
			itemIcon.enabled = false;  
		}  
	}

}

### Purpose:

The purpose of this class is to handle all mechanics of how the player deals damage.

### Breakdown:

void Update() -
	Call Attack Coroutine

private void LightAttack() - 

	This method will detect any enemies that are in the range of an attack and 
	deal damage when the attack is executed.

private void OnDrawGizmosSelected() - 

	Draw sphere around player detailing attack range
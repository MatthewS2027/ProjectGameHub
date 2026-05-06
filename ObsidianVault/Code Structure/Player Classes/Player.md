---
node_size: 25
---

### Purpose:

This class will act as a central hub for all player-related scripts. All subsystems should be components of the Player game object and communicate through this class.

### Contents:

References to PlayerMovement, PlayerHealth, and PlayerCombat classes.

Define Player Base Stats:
	Base Speed
	Max Health
	Attack Damage

Private void Awake() - 

	Retrieve components for all player scripts

Public void Die() - 

	Disable movement, attacking, sprite and collider, and enemy chasing. 
	Game over logic is held here as well.

### Related:

[[PlayerMovement]]
[[PlayerHealth]]
[[PlayerCombat]]

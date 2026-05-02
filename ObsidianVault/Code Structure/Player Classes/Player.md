---
node_size: 25
---

### Purpose:

This class will act as a central hub for all player-related scripts. All subsystems should be components of the Player game object and communicate through this class.

### Breakdown:

- PlayerMovement: Handles movement and dashing
- PlayerCombat: Handles all mechanics with dealing damage
- PlayerHealth: Manages player health, taking damage, and death

References to all of these classes will be stored in Player class to allow for easy communication between scripts.

This class will also store player stats.
These include: 
- Health
- baseSpeed

### Related:

[[PlayerMovement]]
[[PlayerHealth]]
[[PlayerCombat]]

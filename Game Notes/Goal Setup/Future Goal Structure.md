Combat/
     DamageSystem
	    - Centralized Combat Processing
	    - Includes:
	    - Receive damage requests
	    - Apply modifiers / crits / armor or resistance
	    - Trigger status effects / hitstop / knockback
	    - NOT health / animations / or specific weapons
	    - Suggested method: ProcessHit (DamageContext context)
	    - DamageContext Class will hold public references to the following:
		    - GameObject attacker
		    - GameObject victim
		    - damage
		    - damageType
		    - hitDirection
		    - //crit logic
		    - //status effect logic
    Health
	    - Handles Current / Max HP
	    - Healing
	    - Damage intake
	    - Player Death
	    - NOT calculate damage / loot / animations
    Hurtbox
	    - Handles Receiving Hits
	    - Detect valid hitboxes
	    - Forward info to DamageSystem
	    - Can attach to separate parts of enemies for weakpoints / varying damage spots
    Hitbox
	    - Represents active attack areas
	    - Detect collisions
	    - Create DamageContext
	    - Prevent duplicate hits
	    - Should support:
		    - One-hit per swing
		    - Piercing
		    - Multi-hit attacks
		    - DOT zones
		    - Projectile hits
		- Use HashSet<'Hurtbox'> alreadyHit; //clear on hit start
    Knockback
		- Apply physical reaction
		- Handles Push force
		- Stagger
		- Launches
		- Directional Impacts
		- Ensure knockback is generic
    StatusEffects
		- StatusEffectBase
		- BurnEffect
		- SlowEffect
		- FreezeEffect
		- SlowEffect
		- StatusEffectManager
		- StatusEffectData
			- Duration
			- Tick Rate
			- VFX
			- Magnitude
		- StatusEffectRuntime
			- Remaining duration
			- Current stacks
			- Source

Weapons/
    WeaponData
	    - ScriptableObject
		    - Damage
		    - Attack Speed
		    - Combo data
		    - Animation references
		    - Hitbox prefabs
		    - Crit modifiers
		    - Rarity scaling
		    - Weapon type
		    - PURE DATA NO LOGIC
    WeaponController
	    - Runtime weapon behavior
		    - Equip weapon
		    - Execute attacks
		    - Spawn hitboxes
		    - Trigger animations
		    - Handle cooldowns
    WeaponFactory
	    - Create weapon instances
		    - Generate randomized stats
		    - Apply rarity modifiers
		    - Roll affixes
		    - Create runtime weapon instances
		    - Used to create weapons that will be dropped as loot

Enemies/
    EnemyBrain
	    - High level AI coordination
		    - Choose target(s)
		    - Evaluate combat state
		    - Decide behavior priorities
		- Example Decisions
			- Chase Player
			- Retreat
			- Use Special Attack
			- Summon
			- Enrage
    EnemyStateMachine
		- Actual behavior execution
			- Idle
			- Chase
			- Attack
			- Stunned
			- Dead
			- Patrol
			- CastSpell
		- Use separate state classes
    EnemyStats
		- Runtime enemy stats
			- HP
			- Move Speed
			- Damage Modifiers
			- Resistances
			- XP value
			- Loot Quality Modifier
		- Important: Split base stats and runtime stats

Player/
    PlayerController
	    - Movement + state coordination ONLY
	    - Movement
	    - Dashing
	    - State Transitions
	    - NOT: combat, inventory, progression, or UI
    PlayerInput
	    - Read all player related input
	    - Convert into gameplay commands
    PlayerStats
	    - Final computed stats
		    - Attack Power
		    - // Crit chance
		    - Attack Speed
		    - Cooldown Reduction
		    - Move Speed
		- These stats should be final result of all gear / buffs / status effects calculations.

Progression/
    LootGenerator
	    - Generate Loot Drops
		    - Roll rarity
		    - Roll item type
		    - Roll affixes
		    - Apply difficulty modifiers
		- Use weighted rarity tables
		- Item pools
		- Difficulty scaling
    RarityTable
		- Scriptable Object
			- Common Chance
			- Rare Chance
			- Epic Chance
			- Legendary Chance
		- Different levels / encounters can reference different tables
    SaveData
		- Persistent progression only
			- Unlocks
			- Equipped gear
			- // Currency
			- Progression
			- Settings

World/
    SpawnDirector
	    - Spawn:
		    - Elites
		    - Waves
		    - Bosses
		- Control Pacing
		- Dynamic Spawn Intensity
    DifficultyManager
		- Centralized difficulty scaling
		- Scale:
			- Enemy HP
			- Damage
			- Loot quality
			- Spawn rate
			- Elite frequency
		- All scaling multipliers should originate HERE

Future Work:
Inventory/
Abilities/
UI/
Audio/
VFX/
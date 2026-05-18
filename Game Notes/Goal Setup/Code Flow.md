
### Example Combat Flow

- Player uses basic sword attack
- Hitbox script is activated
- DamageContext is created (attacker, baseDamage, damageType, hitDirection)
- Constructed context is sent to hurtbox.ReceiveHit
- New variables set in context (receiver, apply damage modifier, if weak point)
- Complete context is passed to DamageSystem.instance.ProcessHit
- Modifiers and effects are set
- Final damage and context are sent to Health
- Effects and damage are applied to receiver
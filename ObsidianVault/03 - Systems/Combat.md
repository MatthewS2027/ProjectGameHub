# ⚔️ Combat

> Mechanics, hit detection, enemy behavior, and combat feel.

---

## 🎮 Core Mechanics

| Mechanic | Description |
|---|---|
| Movement | Top-down WASD / joystick movement |
| Aiming | Mouse / right stick aim |
| Shooting | Left click / right trigger |
| Dodge / Roll | Space / face button — brief invincibility frames |
| Abilities | Cooldown-based special actions |
| Melee | Short-range fallback attack |

---

## 💥 Hit Detection

- Projectile-based: bullets have a hitbox and travel speed
- Hitscan option for specific weapons (instant raycast)
- Collision layers: Player, Enemy, Projectile, Environment
- Damage numbers displayed on hit for feedback

---

## 🤖 Enemy Behavior

### States
| State | Trigger | Behavior |
|---|---|---|
| Idle | Not aggro'd | Patrols or stands still |
| Alert | Player spotted / noise | Moves toward player |
| Attack | In range | Fires projectiles / charges |
| Staggered | Hit with heavy attack | Brief pause, then resumes |
| Dead | HP ≤ 0 | Death animation, drop loot |

### Aggro Rules
- Line of sight check (raycast)
- Hearing radius (player footstep noise)
- Alerted by other enemies being attacked nearby

---

## 🛡 Player Defenses

| Defense | Effect |
|---|---|
| Dodge Roll | Invincibility frames during roll |
| Cover | Environment blocks projectiles |
| Armor | Reduces incoming damage by flat or percentage |
| Shield (optional) | Absorbs a set amount of damage before breaking |

---

## 🎯 Combat Feel Goals

- Guns should feel punchy with good recoil/screenshake
- Enemy death should be satisfying (ragdoll, particle burst)
- Player should feel quick and agile
- Deaths should feel fair (not cheap)

---

## 🔗 Related

- [[Player]]
- [[Enemy Template]]
- [[Boss Template]]
- [[Game Loop]]

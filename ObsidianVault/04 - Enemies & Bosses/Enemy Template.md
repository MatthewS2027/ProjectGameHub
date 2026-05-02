# 👾 Enemy Template

> Base template for creating new enemy entries.

---

## 📋 Enemy Info

| Field | Value |
|---|---|
| Enemy Name | [Name] |
| Type | Basic / Elite / Mini-Boss |
| Tier | 1 / 2 / 3 |
| First Appears | Level ## |

---

## 📊 Stats

| Stat | Value |
|---|---|
| Max Health | TBD |
| Move Speed | TBD |
| Damage per Hit | TBD |
| Attack Range | Melee / Ranged (## units) |
| Attack Rate | TBD (attacks per second) |
| Drop Chance | TBD % |
| Loot Tier | Common / Uncommon / Rare |

---

## 🤖 Behavior

### AI States
| State | Behavior |
|---|---|
| Idle | Patrol path / stand guard |
| Alert | Move toward player |
| Attack | Execute attack pattern |
| Staggered | Brief pause on heavy hit |
| Dead | Play death animation, drop loot |

### Attack Patterns
_Describe the enemy's attacks here._

1. **Attack Name** — Description (damage, range, windup)
2. **Attack Name** — Description

---

## 🎨 Visual & Audio

| Element | Notes |
|---|---|
| Sprite / Model | [Reference or description] |
| Color Palette | [Reference] |
| Death Effect | [e.g. Explodes, crumbles, dissolves] |
| Sound Effects | [Idle, alert, attack, death] |

---

## 📝 Design Notes

_Gameplay role: what makes this enemy interesting or challenging?_

- 

---

## 🔗 Related

- [[Combat]]
- [[Boss Template]]
- [[Loot]]

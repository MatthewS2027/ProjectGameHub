# 🔄 Game Loop

> The core loop: Run → Fight → Loot → Repeat

---

## 🗺 Overview

```
START
  └─► Enter Level
        └─► Clear Rooms / Defeat Enemies
              └─► Collect Loot
                    └─► Reach Exit / Boss
                          ├─► Win  → Loot Screen → Next Level
                          └─► Lose → Game Over   → Restart / Return to Hub
```

---

## 🔁 Loop Breakdown

### 1. Run
- Player enters a level (dungeon, zone, map)
- Level is composed of rooms or areas to explore
- Each run has randomized room layouts and enemy compositions

### 2. Fight
- Player encounters enemies in each room
- Must clear all enemies to unlock doors / progress
- Combat involves shooting, dodging, and using abilities
- See [[Combat]] for detailed mechanics

### 3. Loot
- Enemies drop loot on death
- Chests and boss rooms contain guaranteed drops
- Loot includes weapons, armor, consumables, and upgrades
- See [[Loot]] for rarity tiers and drop logic

### 4. Repeat
- After completing a level, the player advances to the next
- Loot screen displayed between levels
- Player may choose upgrades or visit a shop
- Loop continues until the final boss or death

---

## ⚡ Loop Feel Goals

| Goal | Target |
|---|---|
| Average run length | 20–30 minutes |
| Time per room | 60–90 seconds |
| Loot screen duration | Quick — under 30 seconds |
| Restart friction | Near-zero — instant restart |

---

## 🔗 Related

- [[Vision]]
- [[Progression]]
- [[Combat]]
- [[Loot]]
- [[Game Flow]]

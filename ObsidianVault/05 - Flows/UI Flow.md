# 🖥 UI Flow

> Menus, HUD, inventory screens, and navigation design.

---

## 📋 Screen Inventory

| Screen | Triggered By | Description |
|---|---|---|
| Main Menu | Game launch | New Run, Continue, Settings, Quit |
| Settings | Main Menu button | Audio, video, controls config |
| Hub / Loadout | Starting a new run | Choose gear before entering first level |
| HUD (In-Game) | During gameplay | Health, ammo, minimap, ability cooldowns |
| Pause Menu | Escape / Start | Resume, Abandon Run, Settings |
| Inventory / Gear | I key / D-pad | View current loadout and stats |
| Loot Screen | Level complete | Review drops, pick upgrade |
| Shop | Shop room in level | Buy items with in-run currency |
| Game Over | Player death | Restart, View Stats, Return to Menu |
| Victory Screen | Final boss defeated | Summary, unlocks, return to menu |

---

## 🎮 HUD Elements

| Element | Position | Description |
|---|---|---|
| Health Bar | Bottom left | Current / Max HP |
| Ammo Counter | Bottom right (near weapon) | Current mag / reserve |
| Weapon Icon | Bottom right | Currently equipped weapon |
| Ability Icons | Bottom center | Ability 1, 2 with cooldown overlay |
| Minimap | Top right | Current room / floor layout |
| Currency | Top left | In-run currency count |
| Enemy Health | Above enemy | Small bar on hover or combat |

---

## 🔄 Navigation Flow

```
Main Menu
  ├─► Settings (back to Main Menu)
  └─► Hub / Loadout
        └─► Level (HUD active)
              ├─► Pause Menu
              │     ├─► Resume
              │     ├─► Settings
              │     └─► Abandon Run → Main Menu
              ├─► Inventory (overlay)
              ├─► Shop (room overlay)
              ├─► Loot Screen (level complete)
              │     └─► Next Level
              └─► Game Over
                    ├─► Restart → Hub / Loadout
                    └─► Main Menu
```

---

## 🎨 UI Style Notes

- Minimal HUD — keep screen space as clean as possible
- Use icons over text where possible
- Consistent color language: red = health, blue = shield, gold = currency
- Loot screen should be quick to navigate — no more than 3 choices at once

---

## 🔗 Related

- [[Game Flow]]
- [[Player]]
- [[Loot]]

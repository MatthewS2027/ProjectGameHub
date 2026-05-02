# 💰 Loot

> Loot tables, rarity tiers, drop logic, and economy.

---

## 🎰 Rarity Tiers

| Tier | Color | Drop Rate | Description |
|---|---|---|---|
| Common | ⚪ White | 60% | Basic weapons and ammo |
| Uncommon | 🟢 Green | 25% | Slightly improved stats |
| Rare | 🔵 Blue | 10% | Significant stat bonuses or special effects |
| Legendary | 🟡 Gold | 4% | Unique effects, high power |
| Exotic | 🟠 Orange | 1% | Gamebreaking/unique mechanics |

---

## 📦 Drop Sources

| Source | Loot Pool | Notes |
|---|---|---|
| Basic Enemy | Common – Uncommon | Random from enemy loot table |
| Elite Enemy | Uncommon – Rare | Higher floor for elites |
| Boss | Rare – Legendary | Guaranteed meaningful drop |
| Chest (standard) | Common – Rare | Placed in level rooms |
| Chest (secret) | Uncommon – Legendary | Hidden or locked rooms |
| Shop | All tiers | Costs in-run currency |

---

## 🎲 Drop Logic

1. On enemy death, roll against the enemy's drop chance (e.g., 40% base)
2. If drop occurs, roll rarity from the tier table
3. Select a random item from that rarity tier's loot pool
4. Spawn item at enemy's death position

### Luck Stat (Optional)
- Player can acquire a "Luck" stat that shifts rarity rolls upward
- e.g., +10 Luck → Common drops at 50%, Uncommon at 30%, etc.

---

## 🗃 Loot Categories

| Category | Examples |
|---|---|
| Weapons | Pistol, SMG, Shotgun, Sniper |
| Armor | Chest piece, Helmet, Boots |
| Consumables | Health pack, Shield charge, Ammo pack |
| Upgrades | Damage up, Fire rate up, Crit chance |
| Currency | Used at shops between levels |

---

## 🔗 Related

- [[Game Loop]]
- [[Progression]]
- [[Player]]

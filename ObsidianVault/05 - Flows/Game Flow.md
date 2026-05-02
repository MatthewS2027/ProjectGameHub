# 🔀 Game Flow

> High-level flow from game start through levels to win/lose states and loot screen.

---

## 🗺 Flow Diagram

```
[Launch Game]
     │
     ▼
[Main Menu]
     │
     ├─► New Run ──────────────────────────────────────────┐
     ├─► Continue (if available)                           │
     └─► Settings / Quit                                   │
                                                           ▼
                                                   [Hub / Loadout Screen]
                                                      (choose starting gear)
                                                           │
                                                           ▼
                                                     [Enter Level]
                                                           │
                                                           ▼
                                                   [Level — Room Loop]
                                                    (clear rooms, collect loot)
                                                           │
                                          ┌────────────────┴───────────────┐
                                          ▼                                ▼
                                    [Reach Exit]                     [Player Dies]
                                          │                                │
                                          ▼                                ▼
                                   [Boss Room?]                     [Game Over Screen]
                                    Yes     No                             │
                                    │       │                    ┌─────────┴──────────┐
                                    ▼       ▼                    ▼                    ▼
                              [Boss Fight] [Next Level]     [Restart Run]     [Return to Menu]
                                    │
                              Win   │   Lose
                               │    │    │
                               ▼         ▼
                        [Loot Screen]  [Game Over]
                               │
                               ▼
                         [Next Level / Final Win]
```

---

## 📋 State Descriptions

| State | Description |
|---|---|
| Main Menu | Entry point — New Run, Continue, Settings, Quit |
| Hub / Loadout | Choose starting weapon/gear before run |
| Enter Level | Level loads, player spawns at entrance |
| Level — Room Loop | Player clears rooms, collects loot, finds exit |
| Boss Room | Optional: defeat boss for guaranteed loot |
| Loot Screen | Post-level review: items gained, choose upgrade |
| Next Level | Load the next level in the sequence |
| Game Over | Run ends — option to restart or quit |
| Final Win | All levels cleared — victory screen, credits |

---

## 🔗 Related

- [[Game Loop]]
- [[UI Flow]]
- [[Boss Template]]

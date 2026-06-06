---
title: "Tuning Pack Requirements Specification for COH2: DEFIANCE"
version: "1.0 Approved"
author: 'Ribs — Team Defiance'
date: 2025-08-08
---

# Tuning Pack Requirements Specification

---

# 1. Introduction

## 1.1 Purpose

CoH2: Defiance is a squad-based real-time strategy modification for Company of Heroes 2, designed to offer a fresh but familiar battlefield experience. It preserves the core identity of CoH2 while reworking its balance, abilities, and gameplay flow to address the shortcomings of the base game.

The purpose of this document is to provide a high-level overview of the project in a structured format, defining its scope, goals, design rules, and non-functional requirements. This ensures consistency in both development and presentation, while serving as a reference point for the team and the wider community.

## 1.2 Scope

CoH2: Defiance is set in an alternate 1946–47 timeline, a narrative framework that justifies certain late-war prototypes and fictional designs appearing alongside historical equipment. The setting exists to serve gameplay rather than to tell a historical story.

- Core gameplay remains grounded in CoH2's squad-based RTS mechanics.
- Continuity is emphasized: players familiar with CoH2 should transition into Defiance smoothly without relearning the entire game.
- New content includes units, abilities, and upgrade systems designed for strategic depth and faction variety.
- Philosophy emphasizes consistency and balance over historical accuracy, ensuring every faction has the tools to compete on equal footing.

## 1.3 Definitions, Acronyms, and Abbreviations

The following terms are specific to Defiance and will be defined collaboratively by the team:

**Vanilla** *(Noun — Alias: VCoH)*
: The base Company of Heroes 2 game, unmodified.

**Tuning Pack** *(Noun)*
: Relic Entertainment's official mod support format for CoH2. Limited to modifying unit statistics and icons; all other file types are inaccessible. Defiance operates within this format.

**RNG** *(Acronym)*
: Random Number Generation. Refers to the random elements that influence combat outcomes such as scatter, accuracy rolls, reload time, weapon cooldown and weapon burst duration.

**Target Size** *(Noun — Alias: Received Accuracy)*
: A multiplier applied to incoming fire that determines how likely a unit is to be hit. Higher target size means the unit is easier to hit.

**Armour** *(Noun)*
: A unit's resistance to incoming damage. Determines whether an attack penetrates or is deflected.

**Penetration** *(Noun)*
: The ability of a projectile to overcome a target's armour value. A successful penetration deals full damage; a failure results in a deflection.

**Deflection Damage** *(Noun — Alias: Deflection, Deflect)*
: The percentage of a weapon's base damage applied to a target when a penetration check fails. Rather than dealing zero damage on a failed penetration, the attack deals a reduced amount determined by the deflection damage value.

**Criticals** *(Noun — Alias: Crits)*
: Negative status effects applied to a unit as a result of combat. Can be ephemeral, resolving after a short duration, or persistent, remaining until the unit is repaired or otherwise addressed. Examples include engine damage, main gun destruction, or crew shocked.

**Slot Item** *(Noun)*
: A squad-level item granted through unit upgrades that overrides the default weapon of the squad member currently assigned to carry it. Slot items are owned by the squad rather than individual members. When the carrying member is killed, the item is passed to the next available squad member. A squad may carry multiple slot items simultaneously.

**Accuracy** *(Noun)*
: The likelihood of a unit's attack connecting with its target.

**Moving Modifiers** *(Noun)*
: Modifiers applied to a unit's base accuracy while in motion. Expressed as multipliers of the unit's stationary weapon accuracy, weapon burst duration, weapon cooldown and weapon scatter.

**Burst Duration** *(Noun — Alias: Burst)*
: The length of time a weapon fires in a single burst before pausing to reload or reacquire a target.

**Weapon Cooldown** *(Noun — Alias: Cooldown)*
: The primary delay between shots when no reload is triggered. Cooldown frequency relative to reload is determined by the Reload Frequency value.

**Reload Frequency** *(Noun — Alias: Frequency)*
: The number of cooldown cycles triggered between shots before a reload is triggered instead. A higher reload frequency value results in fewer reloads occurring during sustained fire.

**Aim Time** *(Noun)*
: A short delay applied directly before firing, split into two phases. Ready Aim Time occurs primarily at the start of combat or after a period of inactivity. Fire Aim Time occurs before every individual shot. If a target moves out of range during the aim phase, the aim time is cancelled and must restart. If no targets are available for longer than the post-firing aim time duration, Ready Aim Time will trigger again when a new target becomes available.

**Focus Fire** *(Noun)*
: A boolean weapon parameter. When enabled, all shots fired during a single burst are directed at the primary target. When disabled, only the first shot targets the primary target, all subsequent shots in the burst are distributed among any valid targets within the weapon's scatter area, including the primary target.

**AoE** *(Acronym)*
: Area of Effect. Refers to attacks that deal damage across a radius rather than to a single target.

**AoE Penetration** *(Noun)*
: The penetration value applied to area of effect damage against armoured targets. Determines whether an armoured unit within an AoE radius takes full damage or deflection damage, using the same pass/fail penetration system as direct fire attacks.

**Weapon Scatter** *(Noun — Alias: Scatter)*
: The deviation in a weapon's hit location from the intended target's position when an accuracy check fails. Any attack incapable of rolling an accuracy check including attack ground commands, skill shots, and arced projectile weapons, will always roll for scatter instead.

**Super Unit** *(Noun)*
: A unit classification applied to high-cost, late-game units with a field presence limit of one per player at any given time. Super Units are doctrine locked and are not available in every match. Despite their combat capabilities, Super Units are subject to the same counter system as all other units in Defiance, with both soft and hard counters available to opposing players.

---

# 2. Overall Description

## 2.1 Product Perspective

CoH2: Defiance is a tuning pack–style modification built on the Company of Heroes 2 framework. It operates within the constraints of the CoH2 tuning pack format, modifying unit statistics, abilities, and upgrade systems without altering core game modes or engine-level functionality.

The mod functions as a comprehensive balance and design overhaul rather than a total conversion. Core visual assets, game modes, and mechanical systems inherited from CoH2 remain intact. All modifications are confined to unit definitions, weapon statistics, ability parameters, and localization strings.

An alternate 1946–47 timeline serves as a narrative framework to justify select fictional and late-war unit designs. This setting does not alter the fundamental gameplay systems inherited from CoH2.

## 2.2 Product Features

- **Faction System:** Five playable factions, each with distinct unit rosters, abilities, and playstyles.
- **Doctrine System:** A standalone doctrine system replacing the vanilla commander model. Each faction has access to 4 doctrines at launch, with additional doctrines planned as post-launch additions.
- **Unit Balance:** All unit statistics including weapon damage, accuracy, and armor values have been reworked from vanilla baselines.
- **Ability System:** Units feature new and reworked abilities replacing or supplementing vanilla functionality.
- **RNG Reduction:** Random elements such as vehicle criticals and explosive damage variance have been streamlined or removed.
- **Upgrade System:** Unit upgrade paths have been reworked to provide distinct strategic choices.

## 2.3 User Classes and Characteristics

- **Casual Players:** Familiar with CoH2 or RTS games in general. Seeking a fresh experience without a steep relearning curve. Expected to engage primarily with the default faction rosters and base doctrine options.
- **Competitive Players:** Experienced CoH2 players seeking deeper strategic options and a balanced alternative to the vanilla meta. Expected to engage extensively with the doctrine system and faction matchups.
- **Modding Community:** Players and developers familiar with CoH2's tuning pack format. May reference this document for structural and design inspiration.

## 2.4 Operating Environment

- **Base Game:** Company of Heroes 2 (Relic Entertainment, 2013).
- **Platform:** PC (Windows).
- **Distribution:** Steam Workshop.
- **Mod Format:** Tuning Pack. Modifies unit statistics, ability parameters, weapon definitions, and localization strings. Does not alter core game modes, engine files, or base game assets.
- **Multiplayer Compatibility:** Compatible with all players who have the mod active via Steam Workshop subscription. Incompatible with other tuning packs running simultaneously.
- **Skin Pack Compatibility:** Custom skin packs are supported and can be used alongside Defiance without conflict.

## 2.5 Design Constraints

- **Format Limitations:** As a tuning pack, Defiance is restricted to modifying unit statistics, ability parameters, weapon definitions, and localization strings. Custom models, textures, and engine-level changes are outside the scope of the format.
- **Visual Consistency:** All units and abilities must utilise existing CoH2 assets. No custom models or textures may be introduced.
- **Accessibility:** The mod must remain accessible to players familiar with vanilla CoH2. The learning curve should be shallow enough that experienced CoH2 players can transition without relearning fundamental mechanics.
- **Faction Balance:** No faction may have a decisive, unavoidable advantage over another. All matchups must have viable counters, both soft and hard.
- **RNG Management:** Random elements must be preserved to maintain unpredictability, but must not be the primary determining factor in match outcomes.
- **Content Scope:** Unit rosters are intentionally limited in size. Quality and balance of existing units takes precedence over quantity of new additions.

---

# 3. System Features

## 3.1 Global Mechanics

### 3.1.1 Cover System

**Description**

Defiance retains the four cover types from vanilla CoH2 — heavy cover (green), light cover (yellow), negative cover (red), and garrison — while modifying several interactions to improve consistency and reduce frustrating mechanics.

**Inputs**

- Infantry squad current cover status and cover type.
- Direction of incoming attack relative to the cover's protected arc.
- Incoming attack type — small arms, explosive, or scoped weapon.

**Processing**

- The system evaluates the direction of the incoming attack relative to the target unit's cover position. If the attack originates outside the cover's protected arc, the unit is considered flanked and receives no cover benefits, taking full damage.
- If a squad is in negative cover, a penalty is applied to their target size, making them easier to hit.
- If a squad is in light cover when an explosive detonates, a minor damage reduction modifier is applied before explosive damage is calculated.
- Crater cover is omnidirectional and provides its bonus regardless of attack direction.
- A broad range of weapons have increased accuracy modifiers against units in cover.
- Scoped weapons apply both increased accuracy and increased damage modifiers against units in cover.

**Outputs**

- Incoming damage and accuracy are modified based on cover type, attack direction, and attack type.

**Deviation from Vanilla**

Vanilla CoH2 applies a flat x1.25 multiplier to incoming damage, target size, and suppression for all weapon classes when a squad is in negative cover. Defiance significantly reduces these penalties and redistributes them as follows:

- Incoming suppression penalty has been removed entirely.
- Incoming small arms damage penalty has been removed entirely. Squads in negative cover no longer take bonus kinetic bullet damage.
- Incoming explosive damage modifier has been reduced from x1.25 to x1.1.
- The primary penalty of negative cover in Defiance is a weapon-class dependent accuracy bonus against the exposed squad:
  - Generic small arms: +10% accuracy
  - Vehicle hull MGs and AA vehicle MGs: +20% accuracy
  - Team weapon HMGs: +40% accuracy

Vanilla applies the same accuracy modifier against covered targets regardless of weapon class. Defiance introduces reduced accuracy and damage penalties for scoped weapons against covered targets, making them significantly more effective at engaging covered squads than standard small arms.

Accuracy modifiers against covered targets have been broadly increased across weapon types compared to vanilla baselines.

---

### 3.1.2 Custom Weapon Statistics (Infantry)

**Description**

All weapons in Defiance use custom statistics tuned for relative faction balance. Two significant systemic changes have been made to weapon behaviour compared to vanilla: light machine gun range performance has been normalised, and accuracy modifiers against cover have been standardised across weapon classes to create a consistent and legible hierarchy of cover effectiveness.

**Inputs**

- Attacking unit weapon class.
- Target unit cover status and cover type.

**Processing**

- Defiance uses vanilla CoH2 damage calculation formulas with custom input values. See Appendix 6.3 for the full damage calculation reference.

**Outputs**

- Incoming accuracy and damage are modified based on weapon class, range, and target cover status.

**Cover Accuracy Modifiers vs. Heavy Cover**

| Weapon Class | Vanilla | Defiance |
|---|---|---|
| Bolt-action rifles | 0.5 | 0.5 |
| Semi-automatic rifles | 0.5 | 0.55 |
| Light machine guns | 0.5 | 0.6 |
| Assault rifles | 0.5 | 0.7 |
| Submachine guns | 0.5 | 0.8 |

*Heavy cover damage modifier remains 0.5 across all weapon classes. Garrison accuracy modifier is 0.05 higher than heavy cover for all weapon classes.*

**Scoped Weapon Modifiers vs. Heavy Cover**

| Weapon Class | Vanilla | Defiance |
|---|---|---|
| Scoped rifles (accuracy) | 0.9 | 0.9 (unchanged) |
| Scoped assault rifles (accuracy) | 0.9 | 0.8 |
| Scoped weapons (damage) | — | applies modifier |

**Deviation from Vanilla**

- Vanilla does not standardise cover accuracy modifiers by weapon class. Defiance introduces a consistent and legible hierarchy across all weapon types.
- Vanilla light machine guns favour long range engagement. Defiance normalises their performance across all ranges.
- Vanilla does not apply a damage modifier for scoped weapons against covered targets. Defiance introduces this modifier for both scoped rifles and scoped assault rifles.

---

### 3.1.3 Weapon Drop Removal

**Description**

Defiance removes the weapon drop system inherited from vanilla CoH2. Infantry slot items are no longer dropped on the ground when a squad member carrying them is killed, eliminating a class of outcomes that punished players for making correct upgrade decisions.

**Inputs**

- Squad member carrying a slot item is killed in combat.

**Processing**

- No weapon drop check is performed.
- The slot item is passed to the next available squad member regardless of circumstance.

**Outputs**

- Slot item is retained by the squad upon squad member death.
- No dropped weapons appear on the ground for pickup by any squad.

**Deviation from Vanilla**

Vanilla CoH2 performs a 10% chance check when a squad member carrying a slot item is killed. A successful check causes the slot item to drop on the ground, where it can be picked up by any nearby infantry squad with available inventory space, including enemy squads.

The vanilla system could result in upgraded weapons being captured by the enemy as a direct consequence of losing a squad member, penalising players for making correct upgrade decisions.

The weapon drop check and all associated drop behaviour have been removed entirely in Defiance.

---

### 3.1.4 Vehicle Critical Removal

**Description**

Defiance removes the RNG-based vehicle critical system inherited from vanilla CoH2. Criticals such as main gun destruction and vehicle abandonment are no longer applied randomly during combat, eliminating a class of outcomes that were determined by chance rather than player decisions.

**Inputs**

- Vehicle taking damage from penetrating attacks in combat.

**Processing**

- Incoming damage is applied to the vehicle's health pool normally.
- No RNG critical check is performed on hit.
- Main gun destruction and vehicle abandonment criticals are not triggered under any circumstance.

**Outputs**

- Vehicle health is reduced by incoming damage.
- No random critical effects are applied.

**Deviation from Vanilla**

- Vanilla CoH2 performs a random critical check on penetrating attacks, with outcomes including main gun destruction and vehicle abandonment.
- Main gun destruction in vanilla can render a vehicle combat ineffective regardless of remaining health, determined entirely by RNG.
- Vehicle abandonment in vanilla allows the enemy to capture and field the abandoned vehicle against its original owner.
- Both criticals have been removed entirely in Defiance.

---

### 3.1.5 Snare System

**Description**

Infantry anti-tank abilities such as HEAT grenades and Panzerfaust shots apply a critical to vehicles on hit, reducing their movement speed temporarily. Defiance modifies the vanilla snare system in three ways: snare effects are guaranteed on hit regardless of target health, the health threshold for persistent engine damage has been lowered, and a stacking condition has been introduced for repeated hits. AT satchels are exempt from these rules and always inflict persistent engine damage on detonation regardless of target health.

**Inputs**

- A snare-capable ability connects with a vehicle target.
- Target vehicle current health value.
- Existing snare status on target vehicle.
- Ability type — standard snare or AT satchel.

**Processing**

- On hit, temporary engine damage is applied to the target regardless of current health.
- If the target is at or below 50% health when hit, engine damage becomes persistent rather than temporary after damage is applied.
- If the target is hit by a second snare ability while temporary engine damage is active, engine damage becomes persistent regardless of current health.
- **Exception:** AT satchels always inflict persistent engine damage on detonation regardless of target health or existing snare status.

**Outputs**

- Target vehicle movement speed is reduced for the duration of the engine damage effect.
- Engine damage status is either temporary or persistent depending on the conditions above.
- AT satchel hits always result in persistent engine damage.

**Deviation from Vanilla**

- Vanilla CoH2 does not guarantee snare on hit; the effect is health dependent.
- Vanilla health threshold for persistent engine damage is 75%. Defiance lowers this to 50%.
- Vanilla does not have a stacking condition for repeated snare hits.
- Vanilla does not have a distinct snare behaviour for AT satchels.
- The changes specifically make single snares less punishing for lighter vehicles, while allowing more counterplay against vehicles with a large HP pool.

---

### 3.1.6 Lethal Grenade System

**Description**

Defiance introduces a custom lethal grenade system replacing vanilla CoH2's grenade damage model. Lethal grenades deal immediate damage to all targets caught within their blast radius upon detonation. Four grenade types are defined, each with distinct blast radius and damage characteristics designed to create meaningful tactical choices between area coverage and lethality.

**Inputs**

- Grenade type.
- Target position relative to blast radius.
- Target damage resistance modifiers from external sources.

**Processing**

- Damage is applied immediately upon detonation to all targets within the blast radius.
- If a bundle grenade detonation connects with a vehicle target, the explosion is classified as a snaring attack and follows the rules defined in 3.1.4.

**Outputs**

- Targets within the blast radius receive immediate damage modified by their damage resistance values.
- Vehicle targets hit by a bundle grenade detonation receive a snare effect as defined in 3.1.6.

**Grenade Type Reference**

| Type | Blast Radius | Damage Profile |
|---|---|---|
| High Explosive (HE) | Small (4 tiles) | High damage. Targets caught in the blast radius are likely to be killed outright unless protected by external damage resistance. |
| Fragmentation (Frag) | Large (5.75 tiles) | Reduced damage. Harder to avoid due to larger blast radius, but more likely to wound than kill. |
| HE-Fragmentation (HE-Frag) | Large (5.75 tiles) | High damage with large blast radius. Combines the lethality of HE with the coverage of Frag. |
| Bundle | Medium (5 tiles) | Higher consistent damage outside the kill radius and significantly higher damage inside it compared to HE. Capable of killing infantry in heavy cover. Applies a snare effect against vehicle targets. |

**Exceptions**

- Impact Rifle Grenades, found on Grenadiere, are derived from the HE grenade type with a reduced blast radius of 3 tiles (compared to the standard 4) and extended range. They detonate on impact rather than after a fuse delay, making them harder to avoid if not anticipated.
- Delayed Fuse Rifle Grenades, found on Rear Echelon Troops, are derived from the Frag grenade type with a 50% damage reduction. The reduced damage reflects their nature as a continuously fired slot item weapon rather than a manually thrown grenade.
- The Heavy Gammon Bomb is classified as a bundle grenade but is exempt from vehicle snare behaviour. As a weapon found exclusively on infiltration squads, vehicles serve as their intended hard counter. The Heavy Gammon Bomb cannot meaningfully damage vehicles by design.
- The Light Gammon Bomb, also found in the mod, is classified as an HE grenade and follows standard HE grenade rules.

**Deviation from Vanilla**

- Vanilla CoH2 features two grenade types: fragmentation and bundle. Defiance replaces vanilla's grenade damage model entirely, introducing four distinct grenade types with custom damage profiles.
- Vanilla bundle grenades do not apply a snare effect against vehicle targets. Defiance classifies bundle grenade detonations against vehicles as snaring attacks, following the rules defined in 3.1.6. This is an emergent interaction that rewards skilled play rather than a primary design intent.

---

### 3.1.7 Explosive Damage System

**Description**

Defiance revises the vanilla CoH2 explosive damage model to reduce the frequency of instant squad wipes and improve the consistency of non-direct hits. All explosive weapons have been individually tuned over the course of the mod's development. Rather than flat damage zones, explosions use three distance thresholds — near, mid, and far — with linear damage scaling between them. The general pattern across most explosive weapons shifts toward smaller near and mid distances with a larger far distance and higher far damage compared to vanilla, resulting in explosives that wound more reliably and wipe less frequently.

**Inputs**

- Explosive weapon AoE size.
- Near, mid, and far distance thresholds and their corresponding AoE damage and AoE penetration modifiers.
- Target position relative to explosion epicentre.
- Target armor value where applicable.

**Processing**

- Defiance uses vanilla CoH2 damage calculation formulas with custom input values. See Appendix 6.3 for the full damage calculation reference.
- Between the centre and the near distance threshold, targets receive the near damage value.
- Between the far distance threshold and the AoE edge, targets receive the far damage value.
- Between the near and far distance thresholds, damage scales linearly based on the target's exact position within that range.
- AoE penetration values are configured per distance threshold and follow the same linear scaling between thresholds.
- A direct hit is required to kill an infantry model from full health under standard conditions.

**Outputs**

- Targets within the blast radius receive damage determined by their position relative to the explosion epicentre, scaled linearly between distance thresholds.
- Armored targets within the blast radius receive full damage or deflection damage depending on whether the AoE penetration check succeeds.
- Craters are generated at the point of detonation based on the weapon's AoE radius and configured animation assets.
- Standard craters provide light, omnidirectional cover as defined in 3.1.1.
- Craters generated by large explosive weapons provide negative cover instead of light cover. These craters persist until overwritten by defensive structures or subsequent explosions.

**Large Explosive Weapons Generating Negative Cover Craters**

- Schwere Gustav
- Raketensprenggranate 4581 (Sturmtiger)
- Bomb, Demolition Number I / Flying Dustbin (Churchill AVRE)
- Demolition Charges
- Goliath Remote Bombs

**Deviation from Vanilla**

- Vanilla CoH2 explosive zone patterns feature proportionally large near zones dealing full base damage and far zones dealing only 5% base damage. This creates a binary outcome where direct hits frequently wipe multiple models instantly while non-direct hits deal negligible damage. Defiance reduces near and mid zone distances and increases far zone distances and far damage values across most explosive weapons, distributing damage more consistently across the blast radius.
- Vanilla explosive animations do not always accurately represent the scale of the weapon being fired. Defiance uses animation stacking with default CoH2 assets to produce explosion visuals that better reflect the size and impact of each weapon.
- Vanilla CoH2 craters provide light omnidirectional cover, consistent with Defiance. However, vanilla does not distinguish between crater types based on weapon size. Defiance introduces negative cover craters exclusively for the largest explosive weapons in the mod, giving players an active tool to deny light cover in crater-heavy areas by deploying large explosive weapons against them.
- Many weapons in Defiance generate slightly smaller craters compared to their vanilla equivalents. This is primarily a visual change reflecting more accurate explosion scale, but has the practical effect of reducing the spread of light cover craters across the battlefield.

---

### 3.1.8 Veterancy System

**Description**

All combat units in Defiance have access to 5 veterancy levels, standardising the system across all factions. Defiance also modifies the XP scaling multipliers for veterancy levels 4 and 5, making elite veterancy harder to reach compared to vanilla.

**Inputs**

- Combat unit accumulates XP through combat actions.
- XP thresholds determine veterancy level progression.

**Processing**

- XP scaling multipliers: 1 / 2 / 4 / 6 / 8
- Veterancy levels 1 through 3 are reached at the same pace as vanilla.
- Veterancy levels 4 and 5 require more XP than vanilla equivalents.

**Outputs**

- Unit advances veterancy level upon reaching XP threshold.
- Veterancy bonuses are applied per level as defined in individual unit specifications.

**XP Threshold Reference**

| Level | Vanilla | Defiance |
|---|---|---|
| 1 | 220 | 220 |
| 2 | 440 | 440 |
| 3 | 880 | 880 |
| 4 | 1100 | 1320 |
| 5 | 1430 | 1760 |

**Deviation from Vanilla**

- Vanilla limits most factions to 3 veterancy levels. Only OKW has access to 5 levels in vanilla. Defiance extends 5 veterancy levels to all factions.
- XP scaling multipliers for levels 4 and 5 have been increased from 5 / 6.5 to 6 / 8, making elite veterancy harder to achieve.

---

## 3.2 Vehicle Mechanics

### 3.2.1 Vehicle Health

**Description**

All vehicle health values in Defiance have been custom tuned from vanilla baselines. Health values are assigned according to vehicle class, with a standardised damage breakpoint of 140 — the base damage of a standard 75mm AP shell — serving as the reference point around which vehicle survivability is balanced. Reducing health values across all vehicle classes compared to vanilla increases the relative lethality of the battlefield without changing the underlying damage calculation system.

**Inputs**

- Vehicle entity hitpoints as defined by vehicle class.
- Attacker weapon base damage value.
- Attacker weapon penetration value.

**Processing**

- If a penetration check succeeds, incoming damage is applied to the vehicle's remaining health pool.
- If incoming damage equals or exceeds the vehicle's remaining health, the vehicle is destroyed.
- Outside of the Snare System, vehicle health values do not interact with or modify any other vehicle systems.

**Outputs**

- Vehicle health is reduced by the damage value of each successful hit.
- Vehicle is destroyed when health reaches zero.

**Vehicle Health Reference**

| Vehicle Class | Vanilla | Defiance |
|---|---|---|
| Rocket artillery | 160 | 140 |
| Ultra-light vehicles | 240 | 240 |
| Half-tracks | 320 | 280 |
| Light tanks | 400 | 360–400 |
| Open-topped medium tanks | 640 | 500 |
| Standard medium tanks | 640 | 560 |
| Premium/doctrinal medium tanks | 640+ | 560+ |
| Heavy tanks | 800–1280 | 720–1320 |

*Heavy tank health values vary based on historical vehicle size and armor profile. The Sherman "Jumbo" sits at the lower end at 720 HP, while the Konigstiger sits at the upper end at 1320 HP.*

**Deviation from Vanilla**

- Vanilla CoH2 uses a 160 damage breakpoint as its balance reference, reflected in higher health values across all vehicle classes. Defiance reduces this breakpoint to 140, lowering health values across the board to increase battlefield lethality while preserving the relative survivability hierarchy between vehicle classes.
- Vanilla does not distinguish between standard and open-topped medium tanks in terms of health. Defiance assigns open-topped medium tanks a lower health value of 500 to reflect their reduced protection.

---

### 3.2.2 Vehicle Weapon Systems

**Description**

All tank cannons and AT guns in Defiance use custom statistics tuned for faction balance. Weapon damage and penetration values are based on caliber and ammo type, with individual adjustments made for balance purposes. Several systemic changes have been made to how tank cannons and AT guns perform compared to vanilla, including standardised range increases, range-dependent accuracy and penetration scaling, and the introduction of deflection damage across most weapon types.

**Inputs**

- Attacker weapon caliber and ammo type.
- Engagement range relative to weapon's maximum range.
- Target vehicle armor value.

**Processing**

- Incoming damage and penetration are calculated using vanilla CoH2 formulas with custom input values.
- If a penetration check fails, deflection damage is applied as a percentage of base damage determined by caliber and ammo type. See Appendix 6.4 for the full deflection damage reference.

**Outputs**

- Successful penetration applies full base damage to the target's health pool.
- Failed penetration applies deflection damage as a percentage of base damage.
- AT guns and tank destroyers deal no significant AoE damage regardless of engagement range.

**Deviation from Vanilla**

- All vehicles equipped with a cannon as their primary weapon display a range indicator — a small circle around the vehicle — as a quality of life improvement. Vanilla CoH2 provides no such indicator, requiring players to estimate engagement range manually.
- All tank cannons and AT guns have been given a uniform +5 range increase compared to vanilla baselines, reducing the time required to engage targets but also making disengagement harder.
- Accuracy, scatter, and penetration values scale with engagement range. Performance improves as range decreases, encouraging aggressive close-range play. Scatter is intentionally worse at maximum range to prevent long range anti-infantry fire.
- Vanilla CoH2 restricts deflection damage to select vehicles like the KV-2. Defiance introduces deflection damage across most tank cannons and AT guns, with values determined by caliber and ammo type.
- The introduction of deflection damage ensures that a failed penetration check is never a zero-damage outcome. In vanilla CoH2, most weapons deal no damage on deflection, making armor a binary pass/fail system. Defiance preserves the penetration hierarchy while ensuring deflections still contribute meaningfully to attrition.
- As a secondary effect, deflection damage ensures that all connecting attacks contribute to the attacker's veterancy progression regardless of penetration outcome, since veterancy XP is awarded based on damage dealt.
- AT guns and tank destroyers deal no significant AoE damage in Defiance. This prevents them from engaging infantry effectively regardless of proximity, preserving their role as dedicated anti-armor weapons.

---

## 3.3 Faction Systems

*(To be filled in later with team insights)*

## 3.4 Doctrine Systems

*(To be filled in later with team insights)*

---

# 4. External Interface Requirements

## 4.1 User Interface (UI/UX)

- All tooltips, unit descriptions, and ability text must be clear, concise, and written in an immersive in-universe tone consistent with the faction they represent.
- Icons and visual cues must integrate seamlessly with existing vanilla CoH2 assets.
- Status effect descriptions must be consistent in format and tone across all factions.
- Ability and upgrade descriptions must communicate function without the use of explicit game terms or fourth-wall language where immersion is required.

## 4.2 Localization

- All strings including unit names, ability descriptions, upgrade text, and status effects must use consistent terminology as defined in Section 1.3.
- English is the primary supported language at launch.
- String formatting must remain extensible to allow for potential community localization contributions post-launch.

---

# 5. Nonfunctional Requirements

## 5.1 Tone and Style Rules

- Unit, ability, and upgrade descriptions must be written in an immersive, in-universe voice appropriate to the faction they represent.
- Descriptions must avoid explicit game terminology, fourth-wall language, and hyperbolic phrasing.
- Each faction maintains a distinct narrative voice:
  - **Soviet Union:** Propagandistic undertones with measured sentimentality.
  - **Wehrmacht:** Clinical and precise.
  - **OKW:** Clinical with restrained character.
  - **US Forces:** Pragmatic and matter-of-fact with dry humor.
  - **UK Forces:** Stoic with understated dry humor.
- Patch notes and technical documentation may use explicit game terminology and fourth-wall language where appropriate.
- All descriptions are subject to a hard character limit of 285 characters.

## 5.2 Balance Goals

- No faction may have a decisive, unavoidable advantage over another.
- All playstyles and unit compositions must have viable counters, both soft and hard.
- Soft counters are preferred over hard counters where possible, to preserve strategic flexibility and raise the skill ceiling.
- Random elements must be preserved to maintain unpredictability, but must not be the primary determining factor in match outcomes.
- Super Units must remain counterable despite their battlefield presence.
- Balance is verified through iterative playtesting rather than purely theoretical modelling.

## 5.3 Performance and Compatibility

- CoH2: Defiance must run reliably on any system capable of running vanilla CoH2.
- The mod must not introduce noticeable performance degradation compared to vanilla.
- Compatibility with future CoH2 patches must be monitored. (LMAO)

---

# 6. Appendices

## 6.1 Design Philosophy Summary

CoH2: Defiance exists to address the shortcomings of vanilla CoH2 and deliver a version of the game where every match is decided by strategy and skill. Two years of iterative playtesting have produced a mod that prioritises consistency, faction balance, and strategic depth over content volume or spectacle.

The core design principles of CoH2: Defiance are:

- Every engagement should have a viable counter.
- Player skill and game knowledge should be the primary determinants of match outcomes.
- No unit, ability, or mechanic should feel arbitrary or beyond the influence of good play.
- Quality and consistency take precedence over quantity.

## 6.2 Inspirations and References

- Company of Heroes 2 (Relic Entertainment, 2013) — base framework and mechanical foundation.
- Historical WWII equipment, doctrine, and unit organisation — reference for unit design and faction identity.
- CoH2 community overhaul mods and tuning packs — structural and design inspiration.

## 6.3 Damage Calculation Formula

*(To be filled in by InvertedJadgpanther)*

## 6.4 Deflection Damage Reference

*Deflection damage values are expressed as percentages of base damage, applied when a penetration check fails. Values vary by ammo type: APCR / AP / HE & HEAT.*

| Caliber | APCR | AP | HE & HEAT |
|---|---|---|---|
| 13–45mm | 2% | 2.5% | 5% |
| 50–57mm | 2.5% | 5% | 10% |
| 75–76mm | 5% | 10% | 20% |
| 81–90mm | 10% | 15% | 30% |
| 100–105mm | 15% | 20% | 40% |
| 120–128mm | 20% | 25% | 50% |
| 150–155mm | 25% | 30% | 60% |
| 200–240mm | 35% | 40% | 75% |
| 280mm+ | 55% | 60% | 75% |

## 6.5 Glossary / Abbreviations

*See Section 1.3.*

// SPDX-FileCopyrightText: 2024 BombasterDS <115770678+BombasterDS@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Piras314 <p1r4s@proton.me>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Misandry <mary@thughunt.ing>
// SPDX-FileCopyrightText: 2025 NazrinNya <137837419+NazrinNya@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 ReserveBot <211949879+ReserveBot@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Svarshik <96281939+lexaSvarshik@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 gus <august.eymann@gmail.com>
// SPDX-FileCopyrightText: 2025 nazrin <tikufaev@outlook.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Goobstation.Server.ChronoLegionnaire.Systems;

namespace Content.Goobstation.Server.ChronoLegionnaire.Components;

/// <summary>
/// Marks projectiles that will apply stasis on hit
/// </summary>
[RegisterComponent, Access(typeof(StasisOnCollideSystem))]
public sealed partial class StasisOnCollideComponent : Component
{
    [DataField("stasisTime")]
    public TimeSpan StasisTime = TimeSpan.FromSeconds(90); //Revenant nerf

    [DataField("fixture")]
    public string FixtureID = "projectile";
}

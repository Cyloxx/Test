using System.Collections.Generic;
using UnityEngine;

public static class WeaponRegistery
{
    private static readonly List<IWeapon> _weapons = new();
    
    public static IReadOnlyList<IWeapon> Weapons => _weapons;

    public static void RegisterWeapon(IWeapon weapon) => _weapons.Add(weapon);
    public static void UnregisterWeapon(IWeapon weapon) => _weapons.Remove(weapon);
}

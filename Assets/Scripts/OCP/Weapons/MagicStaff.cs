using System;
using UnityEngine;

public class MagicStaff : MonoBehaviour, IWeapon
{ 
    [SerializeField] private float spellPower;
    [SerializeField] private float multiplier;
    
    public float GetDamage()
    {
        return spellPower * multiplier;
    }

    private void OnEnable()
    {
        WeaponRegistery.RegisterWeapon(this);
    }

    private void OnDisable()
    {
        WeaponRegistery.UnregisterWeapon(this);
    }
}

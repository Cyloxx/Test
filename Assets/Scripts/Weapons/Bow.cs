using System;
using UnityEngine;

public class Bow : MonoBehaviour, IWeapon
{
    [SerializeField] private float baseDamage;
    public float GetDamage()
    {
        return baseDamage;
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

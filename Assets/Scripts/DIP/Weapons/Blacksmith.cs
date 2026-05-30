using System;
using UnityEngine;

public class Blacksmith : MonoBehaviour
{
    [SerializeField] private MonoBehaviour weaponBehaviour;
    private IWeapon _weapon;

    public IWeapon Craft()
    {
        _weapon = weaponBehaviour as IWeapon;
        return _weapon;
    }
}

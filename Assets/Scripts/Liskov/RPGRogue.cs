using System;
using UnityEngine;

public class RPGRogue : RPGCharacter, IStealthable, IAttackable
{
    public void Stealth()
    {
        Debug.Log(_characterName + " does stealth");
    }

    public void Attack()
    {
        Debug.Log(_characterName + " does attack");
    }
}

using System;
using UnityEngine;

public class RPGWarrior : RPGCharacter, IAttackable
{
    public void Attack()
    {
        Debug.Log(_characterName + " does attack");
    }
}

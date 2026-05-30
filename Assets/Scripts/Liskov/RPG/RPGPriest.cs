using UnityEngine;

public class RPGPriest : RPGCharacter, IHealable, IAttackable
{
    public void Heal()
    {
        Debug.Log(_characterName + " does heal");
    }

    public void Attack()
    {
        Debug.Log(_characterName + " does attack");
    }
}

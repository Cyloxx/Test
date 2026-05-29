using UnityEngine;

public class RPGMage : RPGCharacter, IMagicable, IAttackable
{
    public void Magic()
    { 
        Debug.Log(_characterName + " does magic");
    }

    public void Attack()
    {
        Debug.Log(_characterName + " does attack");
    }
}

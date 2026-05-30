using System.Collections.Generic;
using UnityEngine;

public class RPGCombatManager : MonoBehaviour
{
    [SerializeField] private List<RPGCharacter> fighters;
    
    void Start()
    {
        DoFight();
    }

    private void DoFight()
    {
        foreach (var item in fighters)
        {
            (item as IAttackable)?.Attack();
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class RPGHealingManager : MonoBehaviour
{
    [SerializeField] private List<RPGCharacter> healers;
    
    void Start()
    {
        DoHeal();
    }

    private void DoHeal()
    {
        foreach (var item in healers)
        {
            (item as IHealable)?.Heal();
        }
    }
}

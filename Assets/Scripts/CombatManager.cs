using UnityEngine;

public class CombatManager : MonoBehaviour
{
    private void Start()
    {
        PrintTotalDamage();
    }

    private void PrintTotalDamage()
    {
        float totalDamage = 0;

        foreach (var item in WeaponRegistery.Weapons)
        {
            totalDamage += item.GetDamage();
        }
        
        Debug.Log("total damage: " + totalDamage);
    }
}

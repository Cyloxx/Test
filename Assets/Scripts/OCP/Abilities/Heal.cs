using UnityEngine;

public class Heal : MonoBehaviour, IAbility
{
    [SerializeField] private float baseHeal;
    
    public void Execute()
    {
        Debug.Log("healed " + baseHeal + " health");
    }
}

using UnityEngine;

public class Fireball : MonoBehaviour, IAbility
{
    [SerializeField] private float baseDamage;
    
    public void Execute()
    {
        Debug.Log("fireball dealt " + baseDamage + " damage");
    }
}

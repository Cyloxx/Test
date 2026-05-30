using UnityEngine;

public class WoodBow : MonoBehaviour, IWeapon
{
    [SerializeField] private float damage;
    public float GetDamage()
    {
        Debug.Log("WoodBow Damage: " + damage);
        return damage;
    }
}

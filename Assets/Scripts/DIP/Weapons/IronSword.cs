using UnityEngine;

public class IronSword : MonoBehaviour, IWeapon
{
    [SerializeField] private float damage;
    public float GetDamage()
    {
        Debug.Log("Iron Sword Damage: " + damage);
        return damage;
    }
}

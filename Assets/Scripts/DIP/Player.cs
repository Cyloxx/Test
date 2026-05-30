using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Blacksmith blacksmith;
    private IWeapon _weapon;
    void Start()
    {
        _weapon = blacksmith.Craft();
        UseWeapon();
    }

    private void UseWeapon()
    {
        _weapon.GetDamage();
    }

}

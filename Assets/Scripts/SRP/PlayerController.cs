using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerMovement movement;
    [SerializeField] private PlayerHealth health;
    [SerializeField] private PlayerSave save;
    
    void Start()
    {
        movement.Move();
        health.TakeDamage(5);
        save.Save();
    }

}

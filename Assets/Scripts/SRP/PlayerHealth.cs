using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    private float _currentHealth;

    private void Start()
    {
        _currentHealth  = maxHealth;
    }

    public float GetCurrentHealth()
    {
        return _currentHealth;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        Debug.Log("Player took " + damage +  " damage and remaining health is: " +_currentHealth);
    }
    
    
}

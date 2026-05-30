using UnityEngine;

public class PlayerSave : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    

    public void Save()
    {
        Debug.Log("Saving player health: " + playerHealth.GetCurrentHealth().ToString());
    }
}

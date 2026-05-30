using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    public void Move()
    {
        Debug.Log("Player moving at " +  moveSpeed + " speed");
    }
}

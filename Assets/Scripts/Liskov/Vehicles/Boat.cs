using UnityEngine;

public class Boat : MonoBehaviour, IVehicle
{
    [SerializeField] private float baseSpeed;
    
    public void Move()
    {
        Debug.Log("Boat moving with " + baseSpeed +" speed.");
    }

    private void OnEnable()
    {
        VehicleRegistery.RegisterVehicle(this);
    }

    private void OnDisable()
    {
        VehicleRegistery.UnregisterVehicle(this);
    }
}

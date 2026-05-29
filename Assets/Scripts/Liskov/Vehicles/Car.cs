using UnityEngine;

public class Car : MonoBehaviour, IVehicle
{
    [SerializeField] private float baseSpeed;
    
    public void Move()
    {
        Debug.Log("car moving with " + baseSpeed +" speed.");    
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

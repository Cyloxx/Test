using UnityEngine;

public class FlyingCar : MonoBehaviour, IVehicle
{
    [SerializeField] private float altitude;
    [SerializeField] private float baseSpeed;
    public void Move()
    {
        Debug.Log("Flying car mowing with " + baseSpeed + " speed at " + altitude+ " altitude");
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

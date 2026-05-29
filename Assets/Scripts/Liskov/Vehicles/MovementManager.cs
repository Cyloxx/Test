using UnityEngine;

public class MovementManager : MonoBehaviour
{
    void Start()
    {
        MoveAllVehicles();
    }

    private void MoveAllVehicles()
    {
        foreach (var item in VehicleRegistery.Vehicles)
        {
            item.Move();
        }
    }
}

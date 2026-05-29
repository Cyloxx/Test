using System.Collections.Generic;

public static class VehicleRegistery
{
   private static readonly List<IVehicle> _vehicles = new();
   public static IReadOnlyList<IVehicle> Vehicles => _vehicles;
   
   public static void RegisterVehicle(IVehicle vehicle) => _vehicles.Add(vehicle);
   public static void UnregisterVehicle(IVehicle vehicle) => _vehicles.Remove(vehicle);
}

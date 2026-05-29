using UnityEngine;

public class Medic : Character, IPerformable
{

    public void PerformAction()
    {
        Debug.Log("Medic " + characterName + " heals!");
    }
}

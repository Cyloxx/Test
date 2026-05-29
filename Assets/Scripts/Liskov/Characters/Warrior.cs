using UnityEngine;

public class Warrior : Character, IPerformable
{
    public void PerformAction()
    {
        Debug.Log("Warrior " + characterName + " attacks!");
    }
}

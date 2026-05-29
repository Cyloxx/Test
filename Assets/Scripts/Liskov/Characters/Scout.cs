using UnityEngine;

public class Scout : Character, IPerformable
{
    public void PerformAction()
    {
        Debug.Log("Scout " + characterName + " scouts the area!");
    }
}

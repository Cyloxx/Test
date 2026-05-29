using UnityEngine;

public class Cow : Animal, IAnimalSound
{
    public void MakeSound()
    {
        Debug.Log("Cow " + " moos!");
    }
}

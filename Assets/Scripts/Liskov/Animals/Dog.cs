using UnityEngine;

public class Dog : Animal, IAnimalSound
{
    public void MakeSound()
    {
        Debug.Log("Dog " +" barks!");
    }
}

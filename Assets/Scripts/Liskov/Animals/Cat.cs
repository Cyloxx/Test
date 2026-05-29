using UnityEngine;

public class Cat : Animal, IAnimalSound
{
    public void MakeSound()
    {
        Debug.Log("Cat" + " meows!");
    }
}

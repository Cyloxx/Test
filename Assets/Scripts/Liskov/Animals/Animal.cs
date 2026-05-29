using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    [SerializeField] protected string animalName;
    public void DisplayName()
    {
        Debug.Log("Animal: " + animalName);
    }

}

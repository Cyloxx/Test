using UnityEngine;

public abstract class Character : MonoBehaviour
{
   [SerializeField] private protected string characterName;
   [SerializeField] private protected float health;
   
   public void DisplayInfo()
   {
      Debug.Log("Character name: " + characterName + " health: " + health);
   }
   
}

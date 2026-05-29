using UnityEngine;

public abstract class RPGCharacter : MonoBehaviour
{
   [SerializeField] protected string _characterName;

   public void DisplayInfo()
   {
      Debug.Log("I am: "  + _characterName);
   }
}

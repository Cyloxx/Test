using System.Collections.Generic;
using UnityEngine;

public class AnimalSoundManager : MonoBehaviour
{
   [SerializeField] private List<Animal> animals;

   private void Start()
   {
      TriggerAllSounds();
   }

   private void TriggerAllSounds()
   {
      foreach (var item in animals)
      {
         item.DisplayName();
         (item as IAnimalSound)?.MakeSound();
      }
   }
}

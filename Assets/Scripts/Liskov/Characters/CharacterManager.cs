using System.Collections.Generic;
using UnityEngine;

public class CharacterManager: MonoBehaviour
{
    [SerializeField] private List<Character> characters;
    private void Start()
    {
        RunAll();
    }
    private void RunAll()
    {
        foreach (var item in characters)
        {
            item.DisplayInfo();
            (item as IPerformable)?.PerformAction();
        }
    }
}

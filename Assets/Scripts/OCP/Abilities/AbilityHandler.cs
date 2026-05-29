using System;
using UnityEngine;

public class AbilityHandler : MonoBehaviour
{
    [SerializeField] private MonoBehaviour abilityBehaviour;
    private IAbility _activeAbility;

    private void Start()
    {
        _activeAbility = abilityBehaviour as IAbility;

        if (_activeAbility == null)
        {
            Debug.Log("AbilityHandler: no valid IAbility assigned!");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _activeAbility.Execute();
        }
    }
}

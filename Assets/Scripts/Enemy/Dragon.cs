using UnityEngine;

public class Dragon : MonoBehaviour, IEnemy
{
    [SerializeField] private float baseRewerd;
    [SerializeField] private float multiplier;

    public float GetReward()
    {
        return baseRewerd *  multiplier;
    }

    private void OnEnable()
    {
        EnemyRegistery.RegisterEnemy(this);
    }

    private void OnDisable()
    {
        EnemyRegistery.UnregisterEnemy(this);
    }
}

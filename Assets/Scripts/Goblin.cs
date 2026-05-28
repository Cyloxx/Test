using UnityEngine;

public class Goblin : MonoBehaviour, IEnemy
{
    [SerializeField] private float baseRewerd;

    public float GetReward()
    {
        return baseRewerd;
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

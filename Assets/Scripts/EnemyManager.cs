using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private void Start()
    {
        GetEnemyRewards();
    }

    private float GetEnemyRewards()
    {
        float totalReward = 0;

        foreach (var item in EnemyRegistery.Enemies)
        {
            totalReward += item.GetReward();
        }

        Debug.Log("total enemy reward:" + totalReward);
        return totalReward;
    }
}

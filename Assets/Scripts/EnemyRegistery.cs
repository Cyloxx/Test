using System.Collections.Generic;

public static class EnemyRegistery
{
    private static List<IEnemy> _enemies = new();
    public static IReadOnlyList<IEnemy>  Enemies => _enemies;

    public static void RegisterEnemy(IEnemy enemy) => _enemies.Add(enemy);
    public static void UnregisterEnemy(IEnemy enemy) => _enemies.Remove(enemy);
}

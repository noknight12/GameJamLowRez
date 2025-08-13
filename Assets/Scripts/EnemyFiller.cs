using UnityEngine;

public class EnemyFiller : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawnLocations;

   public void FillEnemies(EnemyCluster enemyCluster)
    {
        for (int i = 0; i < enemyCluster.enemies.Length; i++)
        {
            Instantiate(enemyCluster.enemies[i].enemyObj, spawnLocations[i]);
        }

    }
}

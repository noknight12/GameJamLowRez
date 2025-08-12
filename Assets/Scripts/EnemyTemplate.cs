using UnityEngine;

public abstract class EnemyTemplate : MonoBehaviour
{
    [SerializeField]
    int health = 100;
    [SerializeField]
    TurnManager turnManager;
    [SerializeField]
    Animator animator;
    private void Awake()
    {
        GameObject turnManagerOBJ = GameObject.FindGameObjectWithTag("TurnManager");
        turnManager = turnManagerOBJ.GetComponent<TurnManager>();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0 )
        {

        }
    }

    public abstract void Attack();

    public void EndTurn()
    {
        Invoke(nameof(NextTurn), 3);
    }

    void NextTurn()
    {
        turnManager.StartEnemyAttack();
    }
}

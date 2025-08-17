using UnityEngine;

public abstract class EnemyTemplate : MonoBehaviour
{

    public Sprite enmyIcon;
    public string enemyName;
    [SerializeField]
    float health = 100;
    [SerializeField]
    TurnManager turnManager;
    [SerializeField]
    Animator animator;

    public HealthBar healthBar;
    private void Awake()
    {
        GameObject turnManagerOBJ = GameObject.FindGameObjectWithTag("TurnManager");
        turnManager = turnManagerOBJ.GetComponent<TurnManager>();
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.SetHealth(health);
        if (health <= 0 )
        {
            //win game
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

    private void Start()
    {
        healthBar.SetMaxHealth(health);
    }
}

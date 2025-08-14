using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //board management
    [Header("Board Management")]
    [SerializeField]
    private GameObject Rows;
    public int turnCount = 0;

    //menu management
    [Header("Menu Management")]
    [SerializeField]
    private GameObject actionMenu;

    [Header("To be depracated")]
    [SerializeField]
    private BasicEnemyFight enemyFight;


    //player variables
    [Header("Player Variables")]
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform IdlePosition;
    [SerializeField]
    private CombatMove combatMove;
    [SerializeField]
    private Animator anim;

    [Header("Enemy Variables")]
    //enemy variables
    [SerializeField]
    EnemyFiller enemyFiller;   
    [SerializeField]
    EnemyCluster enemyCluster;
    private int enemyCount = 0;

    

    List<EnemyTemplate> enemyTemplates = new List<EnemyTemplate>();
    void Start()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            EnemyTemplate template = enemy.GetComponent<EnemyTemplate>();
            if (template != null)
            {
                enemyTemplates.Add(template);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Rows.SetActive(false);
            //play animation to move bro
            anim.Play("MoveToRestPlayer");
        }

      
    }


   public void PrepToBattle()
    {
        enemyCount = enemyTemplates.Count - 1;
        Rows.SetActive(true);
        actionMenu.SetActive(false);
        anim.Play("moveToBattle");
        StartEnemyAttack();
        combatMove.slot = 2;
        combatMove.inBattle = true;
    }
    public void StartEnemyAttack()
    {
        if (enemyTemplates.Count > 0)
        {
            if (enemyCount >= 0)
            {
                enemyTemplates[enemyCount].Attack();
                enemyCount--;
            }
            else
            {
                StartPlayerTurn();
            }
        }
       
    }

    public void MovePlayerToRest()
    {
        if (Vector2.Distance(transform.position, player.position) != 0)
        {
            player.position = Vector2.MoveTowards( player.position, transform.position, 0.015f);
            Invoke(nameof(MovePlayerToRest), 0.01f);
            Rows.SetActive(false);
            actionMenu.SetActive(true);
        }
        combatMove.inBattle = false;
    }

    IEnumerator DelayedAttack()
    {
        yield return new WaitForSeconds(3.0f);
        enemyFight.ChooseAttack();
    }

    public void StartPlayerTurn()
    {
        turnCount++;
        MovePlayerToRest();
        actionMenu.SetActive(true);
    }

    public void StartCombat()
    {
        //fill enamies
        turnCount = 0;
    }
}

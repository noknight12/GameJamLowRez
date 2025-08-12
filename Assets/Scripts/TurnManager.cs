using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private GameObject Rows;
    [SerializeField]
    private Transform IdlePosition;
    [SerializeField]
    private Transform Player;
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private BasicEnemyFight enemyFight;
    [SerializeField]
    private GameObject actionMenu;
    [SerializeField]
    private Transform player;
    [SerializeField]
    private CombatMove combatMove;

    private int count = 0;

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
        count = enemyTemplates.Count - 1;
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
            if (count > 0)
            {
                enemyTemplates[count].Attack();
                count--;
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
        MovePlayerToRest();
        actionMenu.SetActive(true);
    }


}

using UnityEngine;
using System.Collections;

public class TurnManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject Rows;
    public Transform IdlePosition;
    public Transform Player;
    public Animator anim;
    public BasicEnemyFight enemyFight;
    public GameObject actionMenu;
    public Transform player;
    public CombatMove combatMove;
    void Start()
    {
        
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
        Rows.SetActive(true);
        actionMenu.SetActive(false);
        anim.Play("moveToBattle");
        StartEnemyAttack();
        combatMove.slot = 2;
        combatMove.inBattle = true;
    }
    public void StartEnemyAttack()
    {
        StartCoroutine(DelayedAttack());
        
    }

    public void movePlayerToRest()
    {
        if (Vector2.Distance(transform.position, player.position) != 0)
        {
            player.position = Vector2.MoveTowards( player.position, transform.position, 0.015f);
            Invoke(nameof(movePlayerToRest), 0.01f);
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
}

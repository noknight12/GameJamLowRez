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

    public void StartEnemyAttack()
    {
        StartCoroutine(DelayedAttack());
        actionMenu.SetActive(false);
    }

    IEnumerator DelayedAttack()
    {
        yield return new WaitForSeconds(3.0f);
        enemyFight.ChooseAttack();
    }
}

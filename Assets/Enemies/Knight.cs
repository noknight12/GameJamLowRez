using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Knight : EnemyTemplate
{
    [SerializeField]
    GameObject threeSlash;
    [SerializeField]
    GameObject twoSlash;
    [SerializeField]
    GameObject pierce;

    [SerializeField]
    GameObject goblin;

    [SerializeField]
    Animator anim;
    public override void Attack()
    {
        int randAttack = Random.Range(0, 3);
        Debug.Log("it works :D");
        anim.Play("KnightComboOne");
        /*
        switch (randAttack)
        { 
            case 0:
                anim.Play("ComboOne");
            break;

            case 1:
                anim.Play("ComboTwo");
                break;

            case 2:
                anim.Play("ComboThree");
                break;
        }
        */

        //EndTurn();
    }

   public void SpawnThreeSlash()
   {
       Instantiate(threeSlash, transform.position, Quaternion.identity);
   }

   public void SpawnTwoSlash()
   {
       Instantiate(twoSlash, transform.position, Quaternion.identity);
   }
   public void SpawnGoblin()
   {
       Instantiate(pierce, transform.position, Quaternion.identity);
   }

}

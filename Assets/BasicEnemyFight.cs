using UnityEngine;

public class BasicEnemyFight : MonoBehaviour
{

    public GameObject[] attackOne;
    int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChooseAttack()
    {
        //int chosenAttack = Random.Range(1, 4);
        int chosenAttack = 1;
        switch (chosenAttack)
        {
            case 1:
                AttackOne();
                break;
            case 2:
                AttackTwo();
                break;
            case 3:
                AttackThree();
                break;
            default:
                break;
        }


    }

    void AttackOne()
    {
        count ++;
        int randNum = Random.Range(0, 2);
        Instantiate(attackOne[randNum]);
        Debug.Log("hello");

        if ( count < 3)
        {
            Invoke(nameof(AttackOne), 3);
            
        }
        else
        {
            count = 0; 
        }
    }

    void AttackTwo()
    {
        Debug.Log("hi");
    }

    void AttackThree()
    {
        Debug.Log("hi");
    }
}

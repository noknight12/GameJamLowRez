using UnityEngine;

public class BasicEnemyFight : MonoBehaviour
{
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
        int chosenAttack = Random.Range(1, 4);

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
        Debug.Log("hi");
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

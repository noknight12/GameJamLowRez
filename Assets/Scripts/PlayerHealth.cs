using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [HideInInspector]
    public float health = 100.0f;
    [SerializeField]
    float maxHealth = 100.0f;
    [SerializeField]
    public float defense = 0;
    [SerializeField]
    private GameObject Scene;

    public int baseDef = 0;

    public int defenseCountDown = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)
        {
           
            Scene.SetActive(false);
            Debug.Log("dead");
        }
        else if (health > maxHealth)
        {
           health = maxHealth;
        }
    }

    public void TakeDamage(int damage)
    {
        float defPercent = defense / 100;
        defPercent = 1 - defPercent;
        float resultDmg =  damage * defPercent;
        health -= resultDmg;
        defenseCountDown--;
        if (defenseCountDown <= 0)
        {
            ResetDef();
            defenseCountDown = 0;
        }
    }


    public void ResetDef()
    {
        defense = baseDef;
    }


}

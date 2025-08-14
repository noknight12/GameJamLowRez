using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100.0f;
    public float maxHealth = 100.0f;
    [SerializeField]
    int defense = 0;
    public GameObject Scene;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
    }

    
}

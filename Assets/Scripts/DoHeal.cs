using UnityEngine;

public class DoHeal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    PlayerHealth health;

    public int healAmount;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Heal()
    {
        health.health += healAmount;
    }
}

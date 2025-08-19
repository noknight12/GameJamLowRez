using UnityEngine;

public class DoHeal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    PlayerHealth health;
    [SerializeField]
    TurnManager turnManager;


    private ApplyBuff applyBuff;

  
    public void Heal(Heal heal)
    {
        applyBuff = GetComponent<ApplyBuff>();
        health.health += applyBuff.Apply(heal);
        health.healthBar.SetHealth(health.health);
        turnManager.PrepToBattle();
    }
}

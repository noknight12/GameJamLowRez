using UnityEngine;

public class DoDefense : MonoBehaviour
{
    [SerializeField]
    PlayerHealth health;
    [SerializeField]
    TurnManager turnManager;
   
  

    private ApplyBuff applyBuff;
   
    public void Defend(Defense defense)
    {
        applyBuff = GetComponent<ApplyBuff>();
        health.defense = applyBuff.Apply(defense);
        health.defenseCountDown = defense.countDown;
        turnManager.PrepToBattle();
    }
}

using UnityEngine;

public class DoDefense : MonoBehaviour
{
    [SerializeField]
    PlayerHealth health;
    [SerializeField]
    TurnManager turnManager;
    [HideInInspector]
    public Defense chosenDefense;
  

    private ApplyBuff applyBuff;
   
    public void Defend()
    {
        applyBuff = GetComponent<ApplyBuff>();
        health.defense = applyBuff.Apply(chosenDefense);
        health.defenseCountDown = chosenDefense.countDown;
    }
}

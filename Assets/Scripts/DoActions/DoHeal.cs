using UnityEngine;

public class DoHeal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    PlayerHealth health;

    [HideInInspector]
    public Heal heal;

    private ApplyBuff applyBuff;

  
    public void Heal()
    {
        applyBuff = GetComponent<ApplyBuff>();
        health.health += applyBuff.Apply(heal);
    }
}

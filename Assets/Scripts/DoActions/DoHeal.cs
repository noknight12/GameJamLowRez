using UnityEngine;

public class DoHeal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    PlayerHealth health;

    [HideInInspector]
    public Heal heal;

    private ApplyBuff applyBuff;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Heal()
    {
        applyBuff = GetComponent<ApplyBuff>();
        health.health += applyBuff.Apply(heal);
    }
}

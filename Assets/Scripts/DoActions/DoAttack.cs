using UnityEngine;

public class DoAttack : MonoBehaviour
{
    [HideInInspector]
    public Attack chosenAttack;
    [HideInInspector]
    public EnemyTemplate chosenTarget;

    private ApplyBuff applyBuff;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack()
    {
        applyBuff = GetComponent<ApplyBuff>();
        chosenTarget.TakeDamage(applyBuff.Apply(chosenAttack));
    }
}

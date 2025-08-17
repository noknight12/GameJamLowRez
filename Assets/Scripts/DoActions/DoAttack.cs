using UnityEngine;

public class DoAttack : MonoBehaviour
{
    //[HideInInspector]
    public Attack chosenAttack;
    [HideInInspector]
    

    private ApplyBuff applyBuff;

    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack(EnemyTemplate chosenTarget)
    {
        animator.Play(chosenAttack.animName);
        applyBuff = GetComponent<ApplyBuff>();
        chosenTarget.TakeDamage(chosenAttack.stat);
    }
}

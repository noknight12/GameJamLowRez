using UnityEngine;

public class StartCombat : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    TurnManager turnManager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CombatStart()
    {
        turnManager.PrepToBattle();
    }
}

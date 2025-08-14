using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject actionMenu;

    [SerializeField]
    private GameObject abilityMenu;

    [SerializeField]
    private GameObject attackMenu;

    [SerializeField]
    private GameObject defenseMenu;

    [SerializeField]
    private GameObject healMenu;

    [SerializeField]
    private GameObject targetMenu;
    public void ShowAbilityMenu()
    {
        abilityMenu.SetActive(true);
        actionMenu.SetActive(false);
    }

   
    public void DisplayAttackMenu()
    {
        attackMenu.SetActive(true);
        abilityMenu.SetActive(false);
    }

    public void DisplayDefenseMenu()
    {
        defenseMenu.SetActive(true);
        abilityMenu.SetActive(false);
    }

    public void DisplayHealMenu()
    {
        healMenu.SetActive(true);
        abilityMenu.SetActive(false);
    }

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

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

   
    public void ReturnToAttack()
    {
        attackMenu.SetActive(true);
        targetMenu.SetActive(false);
    }

    public void ReturnFromDefense()
    {
        defenseMenu.SetActive(false);
        abilityMenu.SetActive(true);
    }

    public void ReturnFromHeal()
    {
        healMenu.SetActive(false);
        abilityMenu.SetActive(true);
    }

    public void ReturnFromAttack()
    {
        attackMenu.SetActive(false);
        abilityMenu.SetActive(true);
    }
}

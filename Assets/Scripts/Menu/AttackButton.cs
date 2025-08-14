using UnityEngine;

public class AttackButton : MonoBehaviour
{
    [SerializeField]
    private GameObject abilityMenu;
    [SerializeField]
    private GameObject attackMenu;
   public void displayAttackMenu()
    {
        attackMenu.SetActive(true);
        abilityMenu.SetActive(false);
    }
}

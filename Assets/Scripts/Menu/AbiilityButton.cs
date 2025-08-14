using UnityEngine;

public class AbiilityButton : MonoBehaviour
{
    [SerializeField]
    GameObject AbilityMenu;

    [SerializeField]
    GameObject ActionMenu;
    public void ShowAbilityMenu()
    {
        AbilityMenu.SetActive(true);
        this.gameObject.SetActive(false);
    }
}

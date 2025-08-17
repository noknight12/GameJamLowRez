using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealMenu : MonoBehaviour
{
    [SerializeField]
    private Inventory inventory;

    private List<Ability> abilities;
    [SerializeField]
    public GameObject buttonPrefab;       // Assign your Button prefab in Inspector
    [SerializeField]
    public Transform buttonParent;

    [SerializeField]
    private DoHeal doHeal;




   
    void Start()
    {
        abilities = inventory.abilities;
        foreach (Ability ability in abilities)
        {
            if (ability is Heal heal)
            {
                
                    GameObject newButton = Instantiate(buttonPrefab, buttonParent);
                newButton.transform.Find("AbilityIcon").GetComponent<Image>().sprite = heal.icon;


                newButton.GetComponent<Button>().onClick.AddListener(() => OnButtonClicked(heal));

                
            }
        }
        

    }

    void OnButtonClicked(Heal heal)
    {
        Debug.Log("Defend :D");
        doHeal.Heal(heal);

        //hide this menu
        this.gameObject.SetActive(false);

    }
}

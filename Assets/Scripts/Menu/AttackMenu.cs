using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttackMenu : MonoBehaviour
{
    [SerializeField]
    private Inventory inventory;

    private List<Ability> abilities;
    [SerializeField]
    public GameObject buttonPrefab;       // Assign your Button prefab in Inspector
    [SerializeField]
    public Transform buttonParent;

    [SerializeField]
    private DoAttack doAttack;

    
    
    // The Panel with VerticalLayoutGroup
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        abilities = inventory.abilities;
        foreach (Attack attack in abilities) 
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = attack.abilityName;

            // Optional: Add click event
            newButton.GetComponent<Button>().onClick.AddListener(() => OnButtonClicked(attack));

        }

    }

    void OnButtonClicked(Attack attack)
    {
        Debug.Log("Clicked: ");
        doAttack.chosenAttack = attack;
        // You can do more here
    }
}

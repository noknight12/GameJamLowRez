using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class InventoryDisplay : MonoBehaviour
{
    public List<Item> items;
    public List<Ability> abilities;
    public List<Attack> attacks;
    public List<Buff> buffs;
    public GameObject buttonPrefab;       // Assign your Button prefab in Inspector
    public Transform buttonParent;        // The Panel with VerticalLayoutGroup
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (Item item in items)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            // newButton.GetComponentInChildren<TextMeshProUGUI>().text = attack.abilityName;

            // Optional: Add click event

        }

        foreach (Ability ability in abilities)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = ability.abilityName;

            // Optional: Add click event
            // newButton.GetComponent<Button>().onClick.AddListener(() => OnButtonClicked(attack));

        }
    }

    void ListAll()
    {
        foreach (Buff buff in buffs)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = buff.buffName;

            // Optional: Add click event
            // newButton.GetComponent<Button>().onClick.AddListener(() => OnButtonClicked(attack));

        }
        foreach (Ability ability in abilities)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = ability.abilityName;

            // Optional: Add click event
            // newButton.GetComponent<Button>().onClick.AddListener(() => OnButtonClicked(attack));

        }
        foreach (Item item in items)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            // newButton.GetComponentInChildren<TextMeshProUGUI>().text = attack.abilityName;

            // Optional: Add click event

        }

       
       


    }

    void ListItems()
    {
        foreach (Item item in items)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = item.itemName;

            // Optional: Add click event
            // newButton.GetComponent<Button>().onClick.AddListener(() => OnButtonClicked(attack));

        }
    }

    void ListBuffs()
    {
        foreach (Buff buff in buffs)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = buff.buffName;

            // Optional: Add click event
            // newButton.GetComponent<Button>().onClick.AddListener(() => OnButtonClicked(attack));

        }
    }

    void ListAbilities()
    {
        
        foreach (Ability ability in abilities)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = ability.abilityName;

            // Optional: Add click event
           // newButton.GetComponent<Button>().onClick.AddListener(() => OnButtonClicked(attack));

        }
    }
}

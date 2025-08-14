using System.Collections.Generic;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    public List<Item> items;
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

    }

    void ListAll()
    {


    }

    void ListItems()
    {

    }

    void ListBuffs()
    {

    }

    void ListAttacks()
    {

    }
}

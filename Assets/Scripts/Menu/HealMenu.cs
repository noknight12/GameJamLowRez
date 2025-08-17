using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
    private DoDefense doDefense;




    // The Panel with VerticalLayoutGroup
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        abilities = inventory.abilities;
        foreach (Defense defense in abilities)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = defense.abilityName;

            // Optional: Add click event
            newButton.GetComponent<Button>().onClick.AddListener(() => OnButtonClicked(defense));

        }

    }

    void OnButtonClicked(Defense defense)
    {
        Debug.Log("Defend :D");
        doDefense.Defend(defense);

        //hide this menu
        this.gameObject.SetActive(false);

    }
}

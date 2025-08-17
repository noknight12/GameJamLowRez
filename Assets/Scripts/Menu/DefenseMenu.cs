using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenseMenu : MonoBehaviour
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
        foreach (Ability ability in abilities)
        {
            if (ability is Defense defense)
            {
                GameObject newButton = Instantiate(buttonPrefab, buttonParent);
               
                newButton.transform.Find("AbilityIcon").GetComponent<Image>().sprite = defense.icon;
                // Optional: Add click event
                newButton.GetComponent<Button>().onClick.AddListener(() => OnButtonClicked(defense));
            }
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

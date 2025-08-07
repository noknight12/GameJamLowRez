using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AttackMenu : MonoBehaviour
{
    
    public List<Attack> attacks;
    public GameObject buttonPrefab;       // Assign your Button prefab in Inspector
    public Transform buttonParent;        // The Panel with VerticalLayoutGroup
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (Attack attack in attacks) 
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
           // newButton.GetComponentInChildren<TextMeshProUGUI>().text = attack.abilityName;

            // Optional: Add click event

        }

    }

    void OnButtonClicked(Attack attack)
    {
        Debug.Log("Clicked: " + attack);
        // You can do more here
    }
}

using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseTargetMenu : MonoBehaviour
{
    List<EnemyTemplate> enemies;

    [SerializeField]
    TurnManager turnManager;

    [SerializeField]
    private GameObject buttonPrefab;       // Assign your Button prefab in Inspector
    [SerializeField]
    private Transform buttonParent;

    [SerializeField]
    private DoAttack doAttack;
    void Start()
    {
        enemies = turnManager.enemyTemplates;
                foreach (EnemyTemplate enemy in enemies)
                {
                    GameObject newButton = Instantiate(buttonPrefab, buttonParent);
                    newButton.GetComponentInChildren<TextMeshProUGUI>().text = enemy.enemyName;

                    // Optional: Add click event
                    newButton.GetComponent<Button>().onClick.AddListener(() => ApplyAttackTarget(enemy));

                }
    }

    void ApplyAttackTarget(EnemyTemplate enemy)
    {
        Debug.Log("Clicked: ");
        doAttack.chosenTarget = enemy;
        // You can do more here
    }
}

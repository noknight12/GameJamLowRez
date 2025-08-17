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
    public EnemyTemplate EnemyTemplate;
    [SerializeField]
    private DoAttack doAttack;
    void Start()
    {
        enemies = turnManager.enemyTemplates;
                foreach (EnemyTemplate enemy in enemies)
                {
                    GameObject newButton = Instantiate(buttonPrefab, buttonParent);
                    newButton.GetComponentInChildren<Image>().sprite = enemy.enmyIcon;

                    // Optional: Add click event
                    newButton.GetComponent<Button>().onClick.AddListener(() => ApplyAttackTarget(enemy));

                }
    }

    void ApplyAttackTarget(EnemyTemplate enemy)
    {
        Debug.Log("hi");
        EnemyTemplate = enemy;
        doAttack.Attack(enemy);
        this.gameObject.SetActive(false);
        // You can do more here
    }
}

using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100.0f;
    bool isDead = false;
    public GameObject Scene;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)
        {
            isDead = true;
            Scene.SetActive(false);
            Debug.Log("dead");
        }
        else
        {
           
        }
    }

    
}

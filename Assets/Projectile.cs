using UnityEngine;

public class Projectile : MonoBehaviour
{
    PlayerHealth playerHealth;
    public int damage = 50;
    public GameObject scene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke(nameof(Delete), 4);
        scene = GameObject.FindWithTag("Scene");
        this.transform.SetParent(scene.transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * 0.1f);
    }

    public void Delete()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerHealth = collision.GetComponent<PlayerHealth>();
            playerHealth.health -= damage;
            Debug.Log("hurt");
        }
    }
}

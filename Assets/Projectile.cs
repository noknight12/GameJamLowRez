using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke(nameof(Delete), 4);
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
}

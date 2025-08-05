using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    public Transform player;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Vector2.Distance(transform.position, player.position) > 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, 0.015f);
        }
        else 
        {
            animator.Play("Transition");
        }
    }
}

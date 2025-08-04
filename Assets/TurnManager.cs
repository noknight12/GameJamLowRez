using UnityEngine;

public class TurnManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject Rows;
    public Transform IdlePosition;
    public Transform Player;
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Rows.SetActive(false);
            //play animation to move bro
            anim.Play("MoveToRestPlayer");
        }
    }
}

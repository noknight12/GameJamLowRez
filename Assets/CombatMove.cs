using UnityEngine;

public class CombatMove : MonoBehaviour
{

    float offset = 1.3f;
    int slot = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 30;
        
    }

    // Update is called once per frame
    void Update()
    {

       
        
        if (Input.GetMouseButtonDown(0))
        {
            if (slot >= 1 && slot <= 4)
            {

                Debug.Log(Input.mousePosition.x);

                if (Input.mousePosition.x < Screen.width / 2)
                {
                    MoveLeft();

                }
                else if (Input.mousePosition.x > Screen.width / 2)
                {
                    MoveRight();
                    
                }
            }
        }
        
    }


    void MoveLeft()
    {
        
        if (slot != 1)
        {
            transform.position = new Vector2(transform.position.x - offset, transform.position.y);
            slot--;

        }
    }

    void MoveRight()
    {
        
        if (slot != 4)
        {
            slot++;
            transform.position = new Vector2(transform.position.x + offset, transform.position.y);
        }
    }
}

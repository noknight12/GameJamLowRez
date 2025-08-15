using UnityEngine;

public class CursorMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    Vector2 mouseCoords;
    void Start()
    {
        mouseCoords = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseCoords = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        Vector2 playerCoord = transform.position;
        if (playerCoord != mouseCoords)
        {
            Vector2 Dir = mouseCoords - playerCoord;
            transform.position = Vector2.MoveTowards(playerCoord,mouseCoords, 0.05f);
        }
    }
}

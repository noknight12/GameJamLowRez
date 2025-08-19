using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Reload()
    {
        SceneManager.LoadScene("World");
    }

  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

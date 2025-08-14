using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleTransition : MonoBehaviour
{
    [SerializeField]
    GameObject mainCam;
    [SerializeField]
    GameObject battleCam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToBattle()
    {
        //cam switch
        mainCam.SetActive(false);
        battleCam.SetActive(true);
    }
}

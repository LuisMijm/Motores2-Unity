using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("MainMenuScene");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameManager.manager.stress -= 77;
        }
    }
}

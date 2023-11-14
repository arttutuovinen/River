using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public bool GameIsPaused = true;
    public GameObject pauseMenuUI;
    public PlayerMovement playerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (GameIsPaused)
            {
                pauseMenuUI.SetActive(false);
                GameIsPaused = false;
                playerScript.isPlayerMovable = true;
            }
            
        }
    }
}

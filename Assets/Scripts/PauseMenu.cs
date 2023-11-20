using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public PlayerMovement playerScript;

    void Start()
    {
        StartCoroutine(PauseMenuCoroutine());
    }

    IEnumerator PauseMenuCoroutine()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                pauseMenuUI.SetActive(false);
                playerScript.StartPlayer();
                yield break;
            }

            yield return null;
        }
    }
}

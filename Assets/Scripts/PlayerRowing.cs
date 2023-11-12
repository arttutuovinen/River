using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRowing : MonoBehaviour
{
    public AudioSource rowingSound;

    void Update()
    {
        if (Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right"))
        {
            rowingSound.enabled = true;
        }
        else
        {
            rowingSound.enabled = false;
        }
    }
}

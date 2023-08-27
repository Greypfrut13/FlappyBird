using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTriggerEnter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();

        if(player != null)
        {
            ScoreHandler.Instance.AddScore();
        }
    }
}

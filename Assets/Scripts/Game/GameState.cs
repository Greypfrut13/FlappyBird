using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameState Instance;

    private bool _isPlaying = false;

    public bool IsPlaying => _isPlaying;

    private void Start() 
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    public void ChangeState(bool isPlaying)
    {
        _isPlaying = isPlaying;
    }
}

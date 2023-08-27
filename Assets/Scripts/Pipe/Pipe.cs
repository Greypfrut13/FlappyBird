using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private float _moveSpeed;

    private void Update() 
    {
        if(GameState.Instance.IsPlaying)
        {
            Move();
        }
    }

    private void Move()
    {
        Vector3 newPosition = new Vector3(-_moveSpeed * Time.deltaTime, 0, 0);

        transform.position += newPosition;
    }

    public void Initialize(float moveSpeed)
    {
        _moveSpeed = moveSpeed;
    }
}

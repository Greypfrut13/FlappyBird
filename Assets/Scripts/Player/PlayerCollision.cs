using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private string _pipeTag;

    [SerializeField] private GameHandler _gameHanlder;

    private Collider2D _collider;

    private void Start() 
    {
        _collider = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag(_pipeTag))
        {
            _gameHanlder.Lose();

            _collider.enabled = false;
        }
    }

    public void ActivateCollider()
    {
        _collider.enabled = true;
    }
}

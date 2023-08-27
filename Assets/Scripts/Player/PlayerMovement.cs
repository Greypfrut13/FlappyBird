using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] [Min(0.0f)] private float _flyForce;

    [SerializeField] private PlayerCollision _playerCollision;

    private Vector3 _startPosition;
    
    private Rigidbody2D _rigidbody;

    private void Start() 
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _startPosition = transform.position;

        _rigidbody.bodyType = RigidbodyType2D.Static;
    }

    public void Fly()
    {
        if(GameState.Instance.IsPlaying)
        {
            _rigidbody.velocity = Vector2.up * _flyForce;
        }
    }

    public void StartFalling()
    {
        _rigidbody.bodyType = RigidbodyType2D.Dynamic;
    }

    public void ResetPosition()
    {
        _rigidbody.bodyType = RigidbodyType2D.Static;

        transform.position = _startPosition;
        _playerCollision.ActivateCollider();
    }
}

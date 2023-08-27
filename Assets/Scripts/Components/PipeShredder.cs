using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeShredder : MonoBehaviour
{
    [SerializeField] private string _pipeTag;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag(_pipeTag))
        {
            Destroy(other.transform.parent.gameObject);
        }
    }
}

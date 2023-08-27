using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PipeSpawner", menuName = "ScriptableObjects/Pipe/PipeSpawner")]
public class SpawnerSo : ScriptableObject
{
    [SerializeField] [Min(0.0f)] private float _spawnDelay;

    [SerializeField] [Min(0.0f)] private float _pipeSpeed;

    [SerializeField] private Pipe[] _pipesPrefab;


    public float SpawnDelay => _spawnDelay;

    public float PipeSpeed => _pipeSpeed;

    public Pipe[] PipesPrefab => _pipesPrefab;
}

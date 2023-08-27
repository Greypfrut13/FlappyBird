using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;

    private  SpawnerSo _selectedDifficulty;

    public void SetSelectedDifficulty(SpawnerSo difficulty)
    {
        _selectedDifficulty = difficulty;
    }

    public IEnumerator SpawnPipeAfterTime()
    {
        while(GameState.Instance.IsPlaying)
        {
            yield return new WaitForSeconds(_selectedDifficulty.SpawnDelay);

            int randomInex = Random.Range(0, _selectedDifficulty.PipesPrefab.Length);

            if(GameState.Instance.IsPlaying)
            {
                Vector3 spawnPosition = new Vector3(_spawnPosition.position.x, _selectedDifficulty.PipesPrefab[randomInex].transform.position.y, 0);

                Pipe pipe = Instantiate(_selectedDifficulty.PipesPrefab[randomInex] , spawnPosition , Quaternion.identity);
                pipe.Initialize(_selectedDifficulty.PipeSpeed);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [Header("Handlers")]
    [SerializeField] private PipeSpawner _pipeSpawner;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private DifficulHandler _difficultyHandler;
    [SerializeField] private ScoreHandler _scoreHandler;

    [Header("UI")]
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private LoseScreen _loseScreen;

    private List<Pipe> _pipes = new List<Pipe>();

    private void Start() 
    {
        ActivateMainMenu();
    }

    private void ActivateMainMenu()
    {
        _mainMenu.gameObject.SetActive(true);
        _loseScreen.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        if(_difficultyHandler.SelectedDifficulty == null) return;

        GameState.Instance.ChangeState(true);

        _playerMovement.StartFalling();

        StartCoroutine(_pipeSpawner.SpawnPipeAfterTime());

        _mainMenu.gameObject.SetActive(false);
    }

    public void Lose()
    {
        GameState.Instance.ChangeState(false);

        _pipes.AddRange(FindObjectsOfType<Pipe>());

        _loseScreen.gameObject.SetActive(true);

        _scoreHandler.ResetScores();
    }

    public void RestartGame()
    {
        foreach(Pipe pipe in _pipes)
        {
            Destroy(pipe.gameObject);
        }

        _pipes.Clear();

        _playerMovement.ResetPosition();

        ActivateMainMenu();
    }
}

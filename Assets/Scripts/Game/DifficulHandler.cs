using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

public class DifficulHandler : MonoBehaviour
{
    [SerializeField] private PipeSpawner _pipeSpawner;

    private SpawnerSo _selectedDifficulty;
    private Button _selectedButton;

    public SpawnerSo SelectedDifficulty => _selectedDifficulty;

    public void ChangeDifficulty(SpawnerSo difficulty)
    {
        _selectedDifficulty = difficulty;

        _pipeSpawner.SetSelectedDifficulty(_selectedDifficulty);
    }

    public void ChangeButtonColor(Button selectedButton)
    {
        if(_selectedButton == null)
        {
            _selectedButton = selectedButton;

            _selectedButton.image.color = Color.blue;

        }
        else
        {
            _selectedButton.image.color = Color.white;

            _selectedButton = selectedButton;

            _selectedButton.image.color = Color.blue;
        }
    }
}

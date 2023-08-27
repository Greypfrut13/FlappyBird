using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public static ScoreHandler Instance;

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _scoresEarnedText;

    private int _currentScore;

    private void Start() 
    {
        if(Instance == null)
        {
            Instance = this;
        }

        _currentScoreText.gameObject.SetActive(false);
    }

    private void SetScoreToText(TextMeshProUGUI scoreText)
    {
        scoreText.text = _currentScore.ToString();
    }

    public void AddScore()
    {
        _currentScore += 1;

        if(_currentScore > 0)
        {
            _currentScoreText.gameObject.SetActive(true);
        }

        SetScoreToText(_currentScoreText);
        SetScoreToText(_scoresEarnedText);
    }

    public void ResetScores()
    {
        _currentScore = 0;

        _currentScoreText.gameObject.SetActive(false);
    }
}

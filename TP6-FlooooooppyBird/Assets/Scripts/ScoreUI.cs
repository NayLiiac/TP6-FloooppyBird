using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] BirdScore _birdScore;
    [SerializeField] private TMP_Text _scoreText;

    void Start()
    {
        _birdScore.ScoreChanged += Notify;
    }

    public void Notify(int newScore)
    {
        _scoreText.text = "Score : " + newScore;
    }
}

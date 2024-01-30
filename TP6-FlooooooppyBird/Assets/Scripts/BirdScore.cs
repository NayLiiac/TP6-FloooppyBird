using System;
using UnityEngine;

public class BirdScore : MonoBehaviour
{
    public int Score;
    public event Action<int> ScoreChanged;
    [SerializeField] PipeGenerator _pipeGenerator;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Score"))
        {
            AddScore(1);
            other.gameObject.GetComponent<PipeMovement>().SelfDisable();
        }
    }

    public void AddScore(int newScore)
    {
        Score += newScore;
        ScoreChanged?.Invoke(Score);

        _pipeGenerator.GeneratePipe();
    }
}

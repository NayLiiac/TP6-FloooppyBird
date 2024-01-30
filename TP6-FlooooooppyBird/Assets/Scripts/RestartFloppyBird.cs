using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartFloppyBird : MonoBehaviour
{
    [SerializeField] BirdBehaviour _bird;
    [SerializeField] private GameObject _endResults;

    public void Start()
    {
        _endResults.SetActive(false);
        _bird.birdIsAlive += Notify;
    }

    public void Notify(bool isAlive)
    {
        if (!_bird.IsAlive)
        {
            _endResults.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

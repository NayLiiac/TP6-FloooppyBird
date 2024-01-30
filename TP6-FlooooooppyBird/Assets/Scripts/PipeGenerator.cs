using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    [SerializeField] private List<Transform> _pipeSpawnPoints = new List<Transform>();

    [SerializeField] PipeObjectPool _pipeObjectPool;

    private void Start()
    {
        StartCoroutine(StartGenerator());
    }

    public void GeneratePipe()
    {
        GameObject pipeGameObject = _pipeObjectPool.GetObjectFromPool();
        if (pipeGameObject != null)
        {
            pipeGameObject.transform.SetPositionAndRotation(_pipeSpawnPoints[Random.Range(0, _pipeSpawnPoints.Count)].position, Quaternion.Euler(0, 0, 0));
            pipeGameObject.SetActive(true);
            pipeGameObject.GetComponent<PipeMovement>().IncreaseDifficulty();
        }
    }

    public IEnumerator StartGenerator()
    {
        yield return new WaitForSeconds(3);
        GeneratePipe();
    }
}

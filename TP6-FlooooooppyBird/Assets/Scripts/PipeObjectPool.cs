using System.Collections.Generic;
using UnityEngine;

public class PipeObjectPool : MonoBehaviour
{
    public GameObject PipePrefab;
    public int PoolSize;
    [SerializeField] private List<GameObject> _poolList;

    public void Start()
    {
        _poolList = new List<GameObject>();

        for (int i = 0; i < PoolSize; i++)
        {
            GameObject obj = Instantiate(PipePrefab);
            obj.SetActive(false);
            _poolList.Add(obj);
        }
    }

    public GameObject GetObjectFromPool()
    {
        foreach (GameObject obj in _poolList)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }

        return null;
    }
}

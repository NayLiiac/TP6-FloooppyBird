using System.Collections;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float Speed = 3;

    void Start()
    {
        Speed = 3;
    }
    void Update()
    {
        transform.Translate(Vector3.left * (Time.deltaTime * Speed));
    }

    public void IncreaseDifficulty()
    {
        Speed *= 1.05f;
    }

    public void SelfDisable()
    {
        StartCoroutine(SelfDisabling(2));
    }

    public IEnumerator SelfDisabling(int i)
    {
        yield return new WaitForSeconds(i);
        gameObject.SetActive(false);
    }
}

using System.Collections;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float Speed = 3;

    void Update()
    {
        transform.Translate(Vector3.left * (Time.deltaTime * Speed));
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

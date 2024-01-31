using System;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    [field : SerializeField] private int _jumpHeight { get;  set; }
    [SerializeField] private Rigidbody _rigidbody;
    public bool IsAlive;
    public event Action<bool> birdIsAlive;

    private void Start()
    {
        IsAlive = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsAlive)
        {
            Jump();
        }
        transform.rotation = Quaternion.Euler(0f, 0f, _rigidbody.velocity.y);
    }

    public void Jump()
    {
        _rigidbody.AddForce(0, _jumpHeight, 0, ForceMode.Impulse);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            IsAlive = false;
            birdIsAlive?.Invoke(IsAlive);
        }
    }
}

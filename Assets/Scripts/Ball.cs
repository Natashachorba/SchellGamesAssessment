using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200f;
    protected Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void ResetPosition()
    {
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.position = Vector3.zero;
        SetStartingVelocity();
    }

    void Start()
    {
        SetStartingVelocity();
    }

    void SetStartingVelocity()
    {
        var randomizedYDirection = Random.Range(0.5f, 1f);
        float xDirection = Random.Range(0, 2) == 0 ? -1 : 1;
        float yDirection = Random.Range(0, 2) == 0 ? -randomizedYDirection : randomizedYDirection;//update to be randomized?

        var direction = new Vector3(xDirection, yDirection, 0f);
        _rigidbody.AddForce(direction * speed);
    }

    public void UpdateForce(Vector3 vector)
    {
        _rigidbody.AddForce(vector);
    }
}

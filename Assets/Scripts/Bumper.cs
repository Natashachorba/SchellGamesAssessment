using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float speed = 10f;
    protected Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void ResetPosition()
    {
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.position = new Vector3(_rigidbody.position.x, 0f, 0f);
    }
}

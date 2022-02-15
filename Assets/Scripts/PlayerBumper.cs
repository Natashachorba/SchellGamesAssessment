using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBumper : Bumper
{
    private Vector3 _direction;

    public PlayerInput playerInput; //consider going back through everything and making them [SerializeField] private instead of public

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        /*if ( Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector3.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector3.down;
        }
        else
        {
            _direction = Vector3.zero;
        }*/
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * speed);
        }
    }

    public void OnMove(InputValue input)
    {
        //doStuff
        var inputVector = input.Get<Vector3>();
        _direction = new Vector3(0f, inputVector.y, 0f);
    }
}

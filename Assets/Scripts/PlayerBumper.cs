using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBumper : Bumper
{
    private Vector3 _direction;//consider going back through everything and making them [SerializeField] private instead of public

    public PlayerInput playerInput; 

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * speed);
        }
    }

    public void OnMove(InputValue input)
    {
        var inputVector = input.Get<Vector3>();
        _direction = new Vector3(0f, inputVector.y, 0f);
    }

    public void OnPause(InputValue input)//need to move this to it's own area and own pause input action class etc
    {
        
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBumper : Bumper
{
    private Vector3 _direction;//consider going back through everything and making them [SerializeField] private instead of public

    public PlayerInput playerInput; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
        var inputVector = input.Get<Vector3>();
        _direction = new Vector3(0f, inputVector.y, 0f);
    }
}

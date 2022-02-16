using UnityEngine;

public class AIBumper : Bumper
{
    public Rigidbody ball;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0f)
        {
            if (ball.position.y > _rigidbody.position.y)
            {
                _rigidbody.AddForce(Vector3.up * speed);
            }
            else if (ball.position.y < _rigidbody.position.y)
            {
                _rigidbody.AddForce(Vector3.down * speed);
            }
        }
        //for added difficulty I can add an else that moves the AI to the center when the ball is moving in the opposite direction
        //for extra hard version it can just constantly follow the ball
        /*else
        {
            // Move towards the center of the field and idle there until the
            // ball starts coming towards the paddle again
            if (_rigidbody.position.y > 0f)
            {
                _rigidbody.AddForce(Vector3.down * speed);
            }
            else if (_rigidbody.position.y < 0f)
            {
                _rigidbody.AddForce(Vector3.up * speed);
            }
        }*/
    }
}

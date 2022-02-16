using UnityEngine;

public class BouncyForBall : MonoBehaviour
{
    public float bounceStrength = 1.01f;

    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector3 normal = collision.GetContact(0).normal;
            var reflection = Vector3.Reflect(ball.transform.position, normal*bounceStrength);
            ball.UpdateForce(reflection);
        }
    }
}

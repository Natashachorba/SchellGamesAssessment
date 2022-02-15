using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounceable : MonoBehaviour
{
    public float bounceStrength = 1f;

    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector3 normal = collision.GetContact(0).normal;
            //ball.UpdateForce(-normal * bounceStrength);
            Vector3.Reflect(ball.transform.position, normal*bounceStrength);
        }
    }
}

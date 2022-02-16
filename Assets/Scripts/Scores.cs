using UnityEngine;
using UnityEngine.Events;

public class Scores : MonoBehaviour
{
    public UnityEvent scoreTrigger;

    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            scoreTrigger.Invoke();
        }
    }
}

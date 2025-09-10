using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitScore = 0;
    void OnCollisionEnter(Collision collision)
    {
        hitScore++;
        Debug.Log("You've bumped into a thing this many times: " + hitScore);
    }
}

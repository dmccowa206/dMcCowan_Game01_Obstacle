using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.darkRed;
        Debug.Log(gameObject.name + " was hit by " + collision.gameObject.name);
    }
}

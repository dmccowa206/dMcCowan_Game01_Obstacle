using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 8f;
    float yValue = 0f;
    void Start()
    {
        PrintInstruction();
    }
    void Update()
    {
        MovePlayer();
    }
    void PrintInstruction()
    {
        Debug.Log("Welcome to the game.");
        Debug.Log("Use WASD or arrow keys to move");
        Debug.Log("Don't bump into things");
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}

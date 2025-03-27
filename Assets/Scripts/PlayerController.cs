using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5.0f;
    private float horizontalInput;
    private float forwardInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        InputAction move = InputSystem.actions.FindAction("Move");
        horizontalInput = move.ReadValue<Vector2>().x;
        forwardInput = move.ReadValue<Vector2>().y;

        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        transform.Translate(horizontalInput* speed * Time.deltaTime * Vector3.right);
    }
}

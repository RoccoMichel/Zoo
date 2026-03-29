using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 50f;
    public float speedMultiplier = 2.5f;

    [Header("References")]
    private InputAction moveAction;
    private InputAction sprintAction;

    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        sprintAction = InputSystem.actions.FindAction("Sprint");

        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {
        Quaternion newRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        Vector3 newMovement = Time.deltaTime * moveSpeed * (sprintAction.IsPressed() ? speedMultiplier : 1) * new Vector3
        {
            x = moveAction.ReadValue<Vector2>().x,
            y = 0,
            z = moveAction.ReadValue<Vector2>().y
        };

        transform.SetPositionAndRotation(transform.position + newMovement, newRotation);
    }
}
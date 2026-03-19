using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 50f;

    [Header("References")]
    private InputAction moveAction;

    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");

        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {
        Quaternion newRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        Vector3 newMovement = Time.deltaTime * moveSpeed * new Vector3
        {
            x = moveAction.ReadValue<Vector2>().x,
            y = 0,
            z = moveAction.ReadValue<Vector2>().y
        };

        transform.SetPositionAndRotation(transform.position + newMovement, newRotation);
    }
}
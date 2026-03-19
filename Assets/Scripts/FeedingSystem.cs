using UnityEngine;
using UnityEngine.InputSystem;

public class FeedingSystem : MonoBehaviour
{
    private InputAction feedingAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        feedingAction = InputSystem.actions.FindAction("Feed");
    }

    // Update is called once per frame
    void Update()
    {
        if (feedingAction.WasCompletedThisFrame())
        {
            Instantiate(Resources.Load<GameObject>("Food"), transform.position, Random.rotation);
        }
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class FeedingSystem : MonoBehaviour
{
    [SerializeField] private Transform spawnPosition;
    private InputAction feedingAction;
    private bool canFeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        feedingAction = InputSystem.actions.FindAction("Feed");
    }

    // Update is called once per frame
    void Update()
    {
        if (feedingAction.WasCompletedThisFrame() && canFeed)
        {
            Instantiate(Resources.Load<GameObject>("Food"), spawnPosition.position, Random.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish")) canFeed = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Finish")) canFeed = false;
    }
}

using UnityEngine;

public class KillAfter : MonoBehaviour
{
    public float time = 2f;

    private void Start()
    {
        Destroy(gameObject, time);
    }
}

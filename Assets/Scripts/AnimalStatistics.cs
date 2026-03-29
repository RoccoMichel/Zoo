using UnityEngine;

public class AnimalStatistics : MonoBehaviour
{
    [Header("Attributes"), SerializeField]
    private float hungerRate = 0.1f;
    [SerializeField] private float thirstRate = 0.2f;
    [Header("Statistics"), Range(0, 1)]
    public float hunger = 1;
    [Range(0, 1)] public float thirst = 1;
}

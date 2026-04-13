using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool debug;

    [Header("References")]
    public static GameController instance;
    private InputAction debugAction;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        debugAction = InputSystem.actions.FindAction("Debug");
    }

    private void Update()
    {
        Application.targetFrameRate = 60;
        if (debugAction.WasPressedThisFrame()) debug = !debug;
    }

    private void OnGUI()
    {
        if (!debug) return;

        // Text
        GUI.Label(new Rect(10, 10, 200, 20), $"ms per frame: {System.Decimal.Round((decimal)(Time.deltaTime * 1000), 2)}");
        GUI.Label(new Rect(10, 40, 200, 20), $"frame per second: {1f / Time.deltaTime}");

        // Buttons
        if (GUI.Button(new Rect(10, 70, 100, 20), "Reload")) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (GUI.Button(new Rect(10, 100, 100, 20), "Exit")) Application.Quit();

        // Sliders
        GUI.Label(new Rect(10, 130, 100, 20), $"Time Scale: {Time.timeScale}x");
        Time.timeScale = GUI.HorizontalSlider(new Rect(10, 160, 150, 40), Time.timeScale, 0.2f, 5);
    }

    private void Reset()
    {
        transform.position = Vector3.zero;
        gameObject.tag = "GameController";
        gameObject.name = "--- GameController ---";
    }
}

using UnityEngine;

[DefaultExecutionOrder(-100)]
public class ServiceHub : MonoBehaviour
{
    public static ServiceHub Instance { get; private set; }

    public GameStateManager gameStateManager;
    public UIManager uiManager;



    private void Awake()
    {
        #region Singleton Pattern

        // Simple singleton setup for a single-scene game
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        #endregion
    }



}

using UnityEngine;

public enum GameState
{
    None,
    Init,
    MainMenu,
    Gameplay,
    Paused
   
}

public class GameStateManager : MonoBehaviour
{
    public GameState currentState { get; private set; }
    public GameState previousState { get; private set; }

    [SerializeField] private string currentActiveState;
    [SerializeField] private string previousActiveState;

    private void Start()
    {
        SetState(GameState.Init);
    }

    public void SetState(GameState newState)
    {
        if (currentState == newState)
        {
            return;
        }

        previousState = currentState;
        currentState = newState;

        currentActiveState = currentState.ToString();
        previousActiveState = previousState.ToString();

        OnGameStateChanged(previousState, currentState);
    }

    private void OnGameStateChanged(GameState previousState, GameState newState)
    {
        switch (newState)
        {
            case GameState.Init:
                Debug.Log("GameState Changed to Init");
                SetState(GameState.MainMenu);
                break;

            case GameState.MainMenu:
                Debug.Log("GameState Changed to MainMenu");
                //Turn on Main Menu UI
                break;

            case GameState.Gameplay:
                Debug.Log("GameState Changed to GamePlay");
                //Turn off All UI
                //Turn on Gameplay UI
                break;

            case GameState.Paused:
                Debug.Log("GameState Changed to Paused");
                break;

            default:
                break;


        }
    }

    private void Update()
    {
        //
    }
}

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum PlayerState { Playing, Won, Lost }
    public PlayerState playerState = PlayerState.Playing;

    public void WinGame()
    {
        if (playerState == PlayerState.Playing)
        {
            playerState = PlayerState.Won;
            Debug.Log("You Win!");
        }
    }

    public void LoseGame()
    {
        if (playerState == PlayerState.Playing)
        {
            playerState = PlayerState.Lost;
            Debug.Log("You Lose!");
        }
    }
}
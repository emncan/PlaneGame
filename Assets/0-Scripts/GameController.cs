using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController gameController;
    private bool isPlaying;

    void Start()
    {
        isPlaying = true;
    }
    private void Awake()
    {
        if (GameController.gameController == null)
        {
            GameController.gameController = this;
        }
        else
        {
            if (this != GameController.gameController)
            {
                Destroy(this.gameObject);
            }
        }
        DontDestroyOnLoad(GameController.gameController.gameObject);
    }
    public bool GetGameState()
    {
        return isPlaying;
    }
    public void SetGameState(bool aGameState)
    {
        isPlaying = aGameState;
    }
}

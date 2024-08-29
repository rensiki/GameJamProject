using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;
public enum GameState
{
    Start,
    Running,
    Minigame,
    Select,
    End
}

public class GameManager : Singleton<GameManager>
{
    public Action startAction;
    public GameState gameState = GameState.Start;
    void Update()
    {
        switch (gameState)
        {
            case GameState.Start:
                startAction();
                gameState = GameState.Running;
                break;
            case GameState.Running:
                break;
            case GameState.Minigame:
                break;
            case GameState.Select:
                break;
            case GameState.End:
                break;
        }
        

    }

}

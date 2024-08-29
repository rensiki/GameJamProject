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
    private int envPoint{get;set;}
    
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
                ChooseEnding();
                break;
        }
    }
    void ChooseEnding(){
        int goodEndingPoint = 100;
        int nomalEndingPoint = 50;
        int badEndingPoint = 20;
        if(envPoint>=goodEndingPoint){

        }else if(envPoint > nomalEndingPoint){

        }else if( envPoint > badEndingPoint){
            
        }
    }
}

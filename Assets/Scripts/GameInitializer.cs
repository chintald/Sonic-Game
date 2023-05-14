using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer
{
    protected HandlePlayerInputs inputHandler;
    protected LoadGameObject loadObjectsObj;
    protected CustomAssetManager assetManager;
    // protected LevelManager levelObj;

    public GameInitializer(){
        assetManager = new CustomAssetManager();
        loadObjectsObj = new LoadGameObject();
        inputHandler = new HandlePlayerInputs();
        // levelObj = new LevelManager();

    }

    public HandlePlayerInputs GetInputHandler(){
        return inputHandler;
    }
    
    public LoadGameObject GetLoadObjectsObj(){
        return loadObjectsObj;
    }

    public CustomAssetManager GetCustomAssetManager(){
        return assetManager;
    }

    // public LevelManager GetLevelManager(){
    //     return levelObj;
    // }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStateSpace;
using UnityEngine.SceneManagement;

public class CustomGameManager : MonoBehaviour
{
    private GameState gameState;
    LevelManager lvlManager;
    GameInitializer supportingInstances;
    LevelManager levelManager;
    private bool levelLoaded = false;
    public int count = 0;
    void Start()
    {  
        gameState = GameState.MainMenu;
        supportingInstances = new GameInitializer();
        lvlManager = new LevelManager();
    }

    // Update is called once per frame
    void Update()
    {  
        switch(gameState)
        {
            case GameState.MainMenu:
                // Check for user input to start the game
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    gameState = GameState.SaveSelect;
                    Debug.Log("Kuch to gadbad hai");
                    Debug.Log(gameState);
                    // Load the next scene or screen here
                }
                else if (Input.GetButton("Cancel"))
                {
                    Application.Quit();
                }
                levelLoaded = false;
                break;

            case GameState.SaveSelect:
                Debug.Log("Ho ja yaarrr");
                if(!levelLoaded){   
                    Debug.Log("Finalyy!!!!!!!");

                    // if (count == 1){
                    Scene loadedScene = SceneManager.GetSceneByBuildIndex(1);

                    SceneManager.SetActiveScene(loadedScene);
                    SceneManager.LoadScene(1, LoadSceneMode.Single);
                    Debug.Log("LOADEDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD!!!!!!!!!!!!!!!!!!!!!");
                    // }
                    count += 1;
                    if (count == 5){
                        count = 3;
                    }
                    levelLoaded = lvlManager.LoadLevelOne();
                    
                }
                if(levelLoaded){
                    lvlManager.PlayLevelOne();
                }
                break;
        }
    }
}

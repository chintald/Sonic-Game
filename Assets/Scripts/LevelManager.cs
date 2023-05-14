using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : GameInitializer
{
    private GameObject playerGO;
    private Rigidbody2D playerRigidBody;

    private bool levelLoaded = false;
    public bool LoadLevelOne()
    {
        Sprite playerSprite = assetManager.GetPlayerSprite();
        Sprite enemySprite = assetManager.GetEnemeySprite();
        playerGO = loadObjectsObj.LoadObject("Player", playerSprite, new Vector2(-10f, 0f));
        GameObject enemyGO = loadObjectsObj.LoadObject("Enemy", enemySprite, new Vector2(10f, 0f));
        levelLoaded = true;
        return levelLoaded;
    }

    public void PlayLevelOne()
    { 
        playerRigidBody = playerGO.GetComponent<Rigidbody2D>();
        inputHandler.controlPlayerMovements(playerRigidBody);
        Vector3 playerPos = playerRigidBody.transform.position;
        // transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z);
    }
}

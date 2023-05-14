using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameObject
{
    public GameObject LoadObject(string nameOfObject, Sprite spriteToLoad, Vector2 locToLoad){
        GameObject go = Object.Instantiate(new GameObject(nameOfObject));
        SceneManager.MoveGameObjectToScene(go, SceneManager.GetSceneByBuildIndex(1));
        
        Debug.Log("SceneName: "+SceneManager.GetActiveScene().name);

        SpriteRenderer spriteRenderer = go.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = spriteToLoad;
        go.transform.position = locToLoad;

        go.AddComponent<Rigidbody2D>();
        go.AddComponent<BoxCollider2D>();
        return go;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAssetManager
{

    // private Sprite GetLevel1Assets(){
    
    // }

    public Sprite GetPlayerSprite(){
        return Resources.Load("characters/player/Idle (32x32)_0") as Sprite;
    }

    public Sprite GetEnemeySprite(){
        return Resources.Load("characters/enemies/Jump (32x32)") as Sprite;
    }
}

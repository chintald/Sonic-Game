// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEditor;

// public class PlayerMovement : MonoBehaviour
// {
//     private Rigidbody2D rb;
//     // public Rigidbody2D enemy;
//     private Sprite spriteToUse;

//     private GameObject enemyGO;
//     private Rigidbody2D enemyRb;
//     // Start is called before the first frame update

//     void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//         enemyGO = new GameObject("Enemy");
//         SpriteRenderer renderer = enemyGO.AddComponent<SpriteRenderer>();
//         Sprite spriteToUse = Resources.Load<Sprite>("Jump (32x32)") as Sprite;
//         renderer.sprite = spriteToUse;
        
//         enemyRb = enemyGO.AddComponent<Rigidbody2D>();
//         enemyRb.position = Vector2.zero;

//         BoxCollider2D enemyCollider = enemyGO.AddComponent<BoxCollider2D>();
//         BoxCollider2D rbBoxCollider = rb.GetComponent<BoxCollider2D>();
//         BoxCollider2D enemyBoxCollider = enemyGO.AddComponent<BoxCollider2D>();
//         enemyBoxCollider.size = rbBoxCollider.size;
//         enemyBoxCollider.offset = rbBoxCollider.offset;
//         enemyBoxCollider.sharedMaterial = rbBoxCollider.sharedMaterial;
//         enemyBoxCollider.isTrigger = rbBoxCollider.isTrigger;

//     }

//     // Update is called once per frame
//     void Update()
//     {
//         float dirX = Input.GetAxis("Horizontal");
//         rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

//         if(Input.GetKeyDown("space")    ){
//             rb.velocity = new Vector2(rb.velocity.x, 7);
//         }

//         enemyRb.velocity = new Vector2(-1f, 0);   
//     }
// }

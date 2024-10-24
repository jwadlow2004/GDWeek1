using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVisual : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    //Reference to the enemy data.
    public EnemyData enemyData;
    
    // Start is called before the first frame update
    void Start()
    {
       //Fills the variable with the right data
       spriteRenderer = GetComponent<SpriteRenderer>();
       // To set the sprite
       spriteRenderer.sprite = enemyData.shipSprite;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

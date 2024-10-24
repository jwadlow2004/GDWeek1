using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemeyData", menuName = "ScriptableObjects/EnemyData")]

public class EnemyData : ScriptableObject
{
    //The data needed to make custom ships.
    public Sprite shipSprite;
    public float shipSpeed;
    public int shipHp;
}

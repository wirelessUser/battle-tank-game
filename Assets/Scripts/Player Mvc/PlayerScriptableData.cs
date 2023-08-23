using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="ScriptableObjects",menuName = "ScriptableObjects/playerTank")]
public class PlayerScriptableData : ScriptableObject
{
    public string playerName;

    public int health;
    public float damage;
    public float movementSpeed;
    public float rotationSpeed;
}

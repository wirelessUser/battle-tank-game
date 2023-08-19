using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EnemySo",menuName = "ScriptableObject/EnemyTankType")]
public class EnemySo : ScriptableObject
{
    public string TankName;
    public float maxHealth;
    public float speed;
    public float movementSpeed;
    public float damageAmount;
    public float firerate;

    public Vector2 size;

   
    EnemySo()
    {
      //  currentHealth = maxHealth;
    }
}

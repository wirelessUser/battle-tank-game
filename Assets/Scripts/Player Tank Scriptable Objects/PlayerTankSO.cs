using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Tank type",menuName = "ScriptableObject/PlayerTankType")]
public class PlayerTankSO : ScriptableObject
{
    public string TankName;
    public float maxHealth;
    public float speed;
    public float currentHealth;
    public Material colorMat;
   


    PlayerTankSO()
    {
        currentHealth = maxHealth;
    }
}

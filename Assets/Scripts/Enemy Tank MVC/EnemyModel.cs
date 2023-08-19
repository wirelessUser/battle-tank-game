using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel : IEnemyTank
{
    public EnemySo enemySo;
    public string tankName;
    public float maxHealth;
    public float speed;
    public float movementSpeed;
    public float damageAmount;
    public float currentHealth;
    public float fireRate;

    public void Initialize(EnemySo dataEnemySo)
    {
        enemySo = dataEnemySo;
        currentHealth = enemySo.maxHealth;

        tankName = enemySo.TankName;
        maxHealth = enemySo.maxHealth;
        speed = enemySo.speed;
        currentHealth = maxHealth;
        speed = enemySo.speed;
        movementSpeed = enemySo.movementSpeed;
        damageAmount = enemySo.damageAmount;

        fireRate = enemySo.firerate;
    }
    public EnemyModel()
    {
        

    }

   


}

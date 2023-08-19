using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
   

    public float damageCapacity;

    public Transform firePoint;

    public float firerate;

    public EnemyController enemyController;

    public EnemySo enemScriptableObj;

    public void InitializController(EnemyController _enemyController)
    {
        enemyController = _enemyController;
    }

}

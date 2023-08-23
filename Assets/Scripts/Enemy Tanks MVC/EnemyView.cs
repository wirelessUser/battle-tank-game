using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    public EnemyController enemyController;
    


    public void SetEnemyController(EnemyController _enemyController)
    {
        enemyController = _enemyController;
    }
}

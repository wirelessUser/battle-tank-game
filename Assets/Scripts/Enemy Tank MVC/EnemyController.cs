using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController
{

    public EnemyModel enemyModel;
   // public EnemyView enemyView;


    public void  Initialize(EnemySo enemydata)
    {
        
        enemyModel.Initialize(enemydata);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankPrefab;
    void Start()
    {
        TankCreator();
    }

   private void TankCreator()
    {
        TankModel tankModel= new TankModel(25,60);
        TankController tankController = new TankController( tankPrefab, tankModel);


    }
}

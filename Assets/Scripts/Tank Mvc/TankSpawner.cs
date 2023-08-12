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
        TankModel tankModel= new TankModel();
        TankController tankController = new TankController( tankPrefab, tankModel);


    }
}

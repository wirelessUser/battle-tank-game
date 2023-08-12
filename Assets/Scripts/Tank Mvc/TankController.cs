using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    public TankModel tankmodelRef;
    public TankView tankViewRef;
    void Start()
    {
        
    }

       public TankController(TankView _tankView,TankModel _tankModel)
    {
        tankmodelRef = _tankModel;
        tankViewRef = _tankView;
        tankmodelRef.SetTankConroller(this);
        tankViewRef.SetTankConroller(this);

        GameObject.Instantiate(tankViewRef);
    }
}

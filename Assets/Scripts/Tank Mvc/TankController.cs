using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    public TankModel tankmodelRef;
    public TankView tankViewRef;

    private Rigidbody tankRb;
    void Start()
    {
        
    }

       public TankController(TankView _tankView,TankModel _tankModel)
    {
        tankmodelRef = _tankModel;
        // tankViewRef = _tankView;
        tankRb = tankViewRef.GetRigidBody();
        tankmodelRef.SetTankConroller(this);
         tankViewRef.SetTankConroller(this);

        tankViewRef= GameObject.Instantiate<TankView>(tankViewRef);
    }



    public void Move(float movement, float movementSpeed)
    {
        tankRb.velocity = tankViewRef.transform.forward * movementSpeed * movement;
    }

    public void Rotate(float rotation, float rotationSpeed)
    {

    }
}

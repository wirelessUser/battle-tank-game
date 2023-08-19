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
        tankViewRef = _tankView;

        tankViewRef = GameObject.Instantiate<TankView>(_tankView);
        tankRb = tankViewRef.GetRigidBody();
        tankmodelRef.SetTankConroller(this);
         tankViewRef.SetTankConroller(this);

    }



    public void Move(float movement, float movementSpeed)
    {
       // Debug.Log($"Movement :{ movement} , movementSpeed : {movementSpeed}");
        tankRb.velocity = tankViewRef.transform.forward * movementSpeed * movement;
      //  tankRb.AddForce(new Vector3(0, 0, movementSpeed*movement));
    }

    public TankModel GetTankModel()
    {
        return tankmodelRef;
    }

    public void Rotate(float rotation, float rotationSpeed)
    {
        Vector3 vector = new Vector3(0f, rotation*rotationSpeed, 0f);

        Quaternion rotationAmount = Quaternion.Euler(vector * Time.deltaTime);
        tankRb.MoveRotation(tankRb.rotation * rotationAmount);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{

    public TankController tankControllerRef;

    public float movement;
    public float rotation;

    public Rigidbody tankrb;

    public void Start()
    {
       
       


        
    }
    public void Update()
    {
        TankMovement();
        Debug.Log($" From TankView--- Movement :{ movement} ");
        tankControllerRef.Move(movement, tankControllerRef.tankmodelRef.movementSpeed);
        tankControllerRef.Rotate(rotation, 40);
    }



    public Rigidbody GetRigidBody()
    {
        return tankrb;
    }
    private void  TankMovement()
    {
        movement = Input.GetAxis("Vertical1");
        rotation = Input.GetAxis("Horizontal1");
    }
    public void SetTankConroller(TankController _tankController)
    {
        tankControllerRef = _tankController;
    }
}

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
        TankMovement();


        if (movement != 0)
        {
            tankControllerRef.Move(movement, 50);
        }
    }


    public Rigidbody GetRigidBody()
    {
        return tankrb;
    }
    private void  TankMovement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }
    public void SetTankConroller(TankController _tankController)
    {
        tankControllerRef = _tankController;
    }
}

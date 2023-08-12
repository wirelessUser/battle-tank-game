using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
    public TankController tankControllerRef;

    public float movementSpeed, rotationSpeed;
    public TankModel(float _movement, float _rotation)
    {
        movementSpeed = _movement;
        rotationSpeed = _rotation;
    }

   
    public void SetTankConroller(TankController _tankController)
    {
        tankControllerRef = _tankController;
    }
}

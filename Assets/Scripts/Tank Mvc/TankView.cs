using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    public TankController tankControllerRef;
    public void SetTankConroller(TankController _tankController)
    {
        tankControllerRef = _tankController;
    }
}

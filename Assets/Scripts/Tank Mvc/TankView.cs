using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{

    public TankController tankControllerRef;

    public float movement;
    public float rotation;

    public Rigidbody tankrb;

    public GameObject mainCam;
    public void Awake()
    {

        mainCam = GameObject.Find("Main Camera");
        mainCam.transform.SetParent(this.gameObject.transform);
        mainCam.transform.localPosition = new Vector3(0, 4.16f, -3.4f);

        
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTankController 
{

    public PlayerTankModel model;
    public PlayerTankView view;
    public Rigidbody rb;

    public PlayerTankController(PlayerTankModel _model, PlayerTankView _view)
    {

        model = _model;
        view = _view;
        rb = view.ReturnRb();
        model.SetController(this);
        view.SetController(this);
        model.SetPlayerTankModel(view.dataSo);
        GameObject.Instantiate(view.gameObject);
    }



    public  void Move(float movementSpeed,float moveDir)
    {
        Debug.Log($"model.movementSpeed{movementSpeed}");
        // rb.velocity = view.transform.forward * moveDir * model.movementSpeed;
        rb.velocity = view.transform.forward * moveDir * movementSpeed*40;
    }
    public void Rotation(float rotationSpeed, float rotateDir)
    {

       
    }
}

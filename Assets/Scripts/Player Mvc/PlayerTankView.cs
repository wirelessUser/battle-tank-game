using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTankView : MonoBehaviour
{
    public PlayerTankController tankController;

    public float horizontalInput;
    public float verticleInput;

    public PlayerScriptableData dataSo;
    public CameraFollow mainCam;
    private void Awake()
    {
        mainCam = GameObject.Find("Main Camera").GetComponent<CameraFollow>();
        mainCam.CameraSetup(this);
    }
    private void Update()
    {
        TakeInput();
        Debug.Log($"horizontalInput{horizontalInput}");
        if (horizontalInput != 0)
        {
            tankController.Move( 30,horizontalInput);
        }

    }

    public void SetController(PlayerTankController _tankController)
    {
        tankController = _tankController;
    }
    public void TakeInput()
    {

        horizontalInput = Input.GetAxis("Horizontal1");
        verticleInput = Input.GetAxis("Vertical1");
    }

    public Rigidbody ReturnRb()
    {

        return this.GetComponent<Rigidbody>();
    }
}
